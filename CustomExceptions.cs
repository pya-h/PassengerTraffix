using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTraffix
{
    class DatabaseOutOfReachException : Exception
    {
        public DatabaseOutOfReachException() : base("اتصال به پایگاه داده با مشکل مواجه شد! در صورتی که نمیدانید مشکل از کجاست به واحد فاوا مراجعه فرمایید.") { }
    }
    
    class FillRequiredFieldsException : Exception
    {
        public FillRequiredFieldsException(string emptyFields) : base("فیلدهای زیر را بصورت کامل پر کنید:\n" + emptyFields) { }
    }
}
