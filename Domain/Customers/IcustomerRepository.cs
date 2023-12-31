﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customers;
public interface IcustomerRepository
{
    Task<Customer?> GetByIdAsync(CustomerId id);
    Task Add(Customer customer); 
}
