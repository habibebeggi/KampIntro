using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
     class PersonalCreditManager: ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal credit payment plan calculated! ");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }

    }
}
