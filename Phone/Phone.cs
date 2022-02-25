using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProject
{
    public class Phone
    {
        private int credit { get; set; }
        public Phone(int cred)
        {
            credit = cred;
        }
        public bool MakePhoneCall()
        {
            if (credit >= 1)
            {
                credit--;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
