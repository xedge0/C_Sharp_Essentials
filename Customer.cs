using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Essentials;

public class Customer
    {
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateOnly CreateDate { get; set; }

    public T Map<T>(IMapper<Customer, T> mapper)
        {
        return mapper.Map(this);
        }

    }