using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2021_dotnet_e_02.Models
{
    public interface IUserRepository
    {
        UserModel GetBy(int id);
        UserModel GetByUsername(string username);
        public ActemiumCustomer GetCustomerByUsername(string username);
        //UserModel GetByEmail(string emailAddress);
        IEnumerable<ActemiumEmployee> GetAllEmployees();
        IEnumerable<ActemiumEmployee> GetAllTechnicians();

        IEnumerable<ActemiumCustomer> GetAllCustomers();

        void Add(UserModel user);
        void Update(UserModel user);



        void AddCustomer(ActemiumCustomer customer);

        void UpdateCustomer(ActemiumCustomer customer);

        void SaveChanges();
    }
}
