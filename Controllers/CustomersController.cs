using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using firstWebapp.Models;
using firstWebapp.ViewModels;

namespace firstWebapp.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index(){
            
            var customers = GetCustomers();

            var viewModel = new CustomersViewModel(){
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int id){

            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if(customer == null){
                return NotFound();
            }

            var viewModel = new CustomersViewModel(){
                Name = customer.Name
            };

            return View(viewModel);
        }

        private IEnumerable<Customer> GetCustomers(){

            return new List<Customer>
            {
                new Customer { Id =1, Name = "John Smith"},
                new Customer { Id =2, Name = "Mary Williams"}
            };

        }
    }
}