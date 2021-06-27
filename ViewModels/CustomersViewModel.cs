using System;
using System.Collections.Generic;
using firstWebapp.Models;

namespace firstWebapp.ViewModels
{
    public class CustomersViewModel
    {
        public IEnumerable<Customer> Customers{ get; set;}

        public int Id {get; set;}

        public string Name{ get; set;}

    }
}