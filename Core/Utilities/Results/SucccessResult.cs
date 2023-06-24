using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SucccessResult:Result
    {
        public SucccessResult(string message):base(true,message)
        {

        }
        public SucccessResult():base(false) 
        {

        }
    }
}
