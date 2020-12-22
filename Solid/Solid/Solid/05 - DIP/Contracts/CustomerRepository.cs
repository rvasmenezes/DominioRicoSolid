using System;

namespace Solid._05___DIP.Contracts
{
    public class CustomerRepository : ICustomerSeviceRepository
    {
        public void Save(string name)
        {
            Console.WriteLine(name);
        }
    }
}
