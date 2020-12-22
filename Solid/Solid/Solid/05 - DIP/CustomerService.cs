using Solid._05___DIP.Contracts;

namespace Solid._05___DIP
{
    public class CustomerService
    {

        private ICustomerSeviceRepository _repository;

        public CustomerService(ICustomerSeviceRepository repository)
        {
            _repository = repository;
        }

        public void Register(string name)
        {
            _repository.Save(name);
        }
    }
}
