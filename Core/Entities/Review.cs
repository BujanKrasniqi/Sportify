using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities;

public class Review : BaseEntity
{
    public string? ReviewText { get; set; } 
    public int Score { get; set; }          

    public int ProductId { get; set; }
    public Product Product { get; set; } 
}

