﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetFlix.ApiGateway.Models
{
    public class ProductsQuantity
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
