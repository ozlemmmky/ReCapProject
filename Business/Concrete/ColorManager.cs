using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SucccessResult(Messages.Added);
        }

        public IResult Delete(Color color)
        {
           _colorDal.Delete(color);
            return new SucccessResult(Messages.Deleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<List<Color>> GetColorId(int id)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(p => p.ColorId == id));
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SucccessResult(Messages.Updated);
        }
    }
}
