﻿using Core.Utilities.Helpers.GUIDhelper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileHelperManager : IFileHelper
    {
        public void Delete(string filePath)
        {
            if(File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public string Update(IFormFile file, string filePath, string root)
        {
           if(File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            return Upload(file, root);
        }

        public string Upload(IFormFile file, string root)
        {
           if(file.Length> 0)
            {
                if(!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }
                string extension=Path.GetExtension(file.FileName);//seçtiğimi< dizinin yolu
                string guid = GuidHelper.CreateGuid();
                string filepath = guid + extension;

                using(FileStream fileStream= File.OpenWrite(root+filepath))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                    return filepath;

                }
            }
            return null;
        }
    }
}
