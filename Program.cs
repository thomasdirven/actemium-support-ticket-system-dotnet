using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2021_dotnet_e_02.Data;
using _2021_dotnet_e_02.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace _2021_dotnet_e_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("START");
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    IEnumerable<ActemiumCompany> list = db.ActemiumCompanies.ToList();
                    //Console.WriteLine(list);
                    foreach (ActemiumCompany company in list)
                    {
                        Console.WriteLine(company.Name);
                    }

                    /*
                    // doesnt work yet
                    IEnumerable<ActemiumTicket> list1 = db.ActemiumTickets.ToList();
                    //Console.WriteLine(list);
                    foreach (ActemiumTicket ticket in list1)
                    {
                        Console.WriteLine(ticket.Priority);
                    }
                    // doesnt work yet
                    IEnumerable<ActemiumTicketChange> list2 = db.ActemiumTicketChanges.ToList();
                    //Console.WriteLine(list);
                    foreach (ActemiumTicketChange ticketChange in list2)
                    {
                        Console.WriteLine(ticketChange.UserRole);
                    }
                    */
                    Console.WriteLine("#########USERS########");
                    IEnumerable<UserModel> list5 = db.Users.ToList();
                    foreach (UserModel User in list5)
                    {
                        Console.WriteLine(User.UserName + " " + User.LoginAttempts);
                    }
                    
                    Console.WriteLine("#########CUSTOMERS########");
                    IEnumerable<UserModel> list3 = db.Customers.ToList();
                    foreach (ActemiumCustomer Customer in list3)
                    {
                        Console.WriteLine(Customer.UserName);
                    }
                    
                    Console.WriteLine("#########EMPLOYEES########");
                    IEnumerable<UserModel> list4 = db.Employees.ToList();
                    foreach (ActemiumEmployee Employee in list4)
                    {
                        Console.WriteLine(Employee.UserName + " " + Employee.Role);
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("EINDE");

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
