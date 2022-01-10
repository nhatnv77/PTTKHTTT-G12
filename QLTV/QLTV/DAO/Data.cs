using QLTV.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DAO
{
    public static class Data
    {
        private static QLTVEntities instance;

        public static QLTVEntities Instance
        {
            get => instance;
        }

        static Data()
        {
            instance = new QLTVEntities();
        }
    }
}
