using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentTest.Entities
{
    public class PhoneNumber
    {
        public virtual int Id { get; set; }
        public virtual String areaCode { get; set; }
        public virtual String number { get; set; }
        public virtual Employee theEmployee { get; set; }

        public virtual String fullNumber
        {
            get { return String.Format("{0}-{1}", areaCode, number); }
        }

        public PhoneNumber()
        {

        }
        public PhoneNumber(string code, String num)
        {
            areaCode = code;
            number = num;
        }
    }
}
