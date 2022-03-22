using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    class Ajanda
    {
        private string telAdi;
        private string telNo;

        public Ajanda(string telAdi, string telNo)
        {
            this.telAdi = telAdi;
            this.telNo = telNo;
        }

        public string TelAdi
        {
            get
            {
                return telAdi;
            }
            set
            {
                telAdi = value;
            }
        }
        public string TelNo
        {
            get
            {
                return telNo;
            }
            set
            {
                telNo = value;
            }
        }


    }
}
