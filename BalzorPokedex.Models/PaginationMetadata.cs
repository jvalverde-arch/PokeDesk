using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPokedex.Models
{
    public class PaginationMetadata
    {

        public int CurrentPage { get; set; } 

        public int TotalPages { get; set; }

        public int TotalCount { get; set; }

        public bool HasPrevius => CurrentPage > 1;

        public bool HasNext => CurrentPage < TotalPages;
    }
}
