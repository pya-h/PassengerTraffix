using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTraffX
{
    class DatabaseOutOfReachException : Exception
    {
        public DatabaseOutOfReachException() : base("اتصال به دیتابیس با مشکل مواجه شد!") { }
    }
}
