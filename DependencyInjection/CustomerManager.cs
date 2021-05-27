using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class CustomerManager
    {
        private ILogger _logger;
        public CustomerManager(ILogger logger)
        {
            this._logger = logger;
        }
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " Added.");
            _logger.log();
        }
    }
}
