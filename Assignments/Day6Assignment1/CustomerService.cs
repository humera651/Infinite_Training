using Castle.Core.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignment1
{
    public class Customer
    {
        public string Name { get; set; }
    }
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int id);
    }
    public class CustomerService
    {
        private readonly ICustomerRepository _repo;

        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public string GetCustomerName(int id)
        {
            var customer = _repo.GetCustomerById(id);
            return customer?.Name ?? "Unknown";
        }
    }
}
