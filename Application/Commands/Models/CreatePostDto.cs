using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Models
{
    public class CreatePostDto
    {
      
        public string Topic { get; set; }
        public string Content { get; set; }
        public string Slug { get; set; }   
        public string AuthorName { get; set; }
    }
}
