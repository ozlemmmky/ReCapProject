﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelper _fileHelper;
        
        public CarImageManager(ICarImageDal carImageDal,IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file,CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfCarImageCount(carImage));
            if(result!=null)
            {
                return result;
            }
            carImage.ImagePath = _fileHelper.Upload(file, PathConstants.ImagesPath);
            carImage.Date = DateTime.Now;

            _carImageDal.Add(carImage);
            return new SucccessResult(Messages.Added);


        }

        public IResult Delete(CarImage carImage)
        {

            _fileHelper.Delete(PathConstants.ImagesPath + carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SucccessResult(Messages.Deleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetCarId(int id)
        {
            _carImageDal.GetAll(p=>p.CarId==id);
            return new SuccessDataResult<List<CarImage>>(Messages.ListedById);
        }

        public IResult Update(IFormFile file,CarImage carImage)
        {
            carImage.ImagePath = _fileHelper.Update(file, PathConstants.ImagesPath + carImage.ImagePath, PathConstants.ImagesPath);
            _carImageDal.Update(carImage);
            return new SucccessResult(Messages.Updated);
         }
        private IResult CheckIfCarImageCount(CarImage carImage)
        {
            var result = _carImageDal.GetAll(p => p.CarId == carImage.CarId).Count;
            if(result>5)
            {
                return new ErrorResult();
            }
            return new SucccessResult();
        }


    }
}
