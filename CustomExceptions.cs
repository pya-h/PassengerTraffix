using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerTraffix
{
    class DatabaseOutOfReachException : Exception
    {
        public DatabaseOutOfReachException() : base("اتصال به پایگاه داده با مشکل مواجه شد! در صورتی که نمیدانید مشکل از کجاست به واحد فاوا مراجعه فرمایید.") { }
    }
    
    class FillRequiredFieldsException : Exception
    {
        public FillRequiredFieldsException(string emptyFields) : base("فیلدهای زیر را بصورت کامل پر کنید:\n" + emptyFields) { }
    }
    class WrongCredentialsException : Exception
    {
        public WrongCredentialsException() : base("رمز عبور وارد شده اشتباه است!") { }
    }

}
