﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Entities;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public double Price { get; set; }

    public int CategoryId { get; set; }

    public string Description { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;
    
    public virtual Category? Category { get; set; } = null!;
    
    public virtual ICollection<OrderItem>? OrderItems { get; set; } = new List<OrderItem>();
}
