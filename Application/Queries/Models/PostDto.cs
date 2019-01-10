using Domain.Entities;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Models
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public string Content { get; set; }
        public string Slug { get; set; }
        public Instant Published { get; set; }
        public string AuthorName { get; set; }      

    }
}
