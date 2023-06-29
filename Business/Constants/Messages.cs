using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "eklendi";
        public static string Deleted = "Silindi";
        public static string Updated = "Güncellendi";
        internal static List<CarImage> Listed;
        internal static List<CarImage> ListedById;
    }
}
