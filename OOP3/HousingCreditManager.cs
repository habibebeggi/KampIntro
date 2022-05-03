using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class HousingCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Housing loan payment plan calculated! ");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
