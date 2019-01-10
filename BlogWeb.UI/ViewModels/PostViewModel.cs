using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWeb.UI.ViewModels
{
    public class PostViewModel
    {
        public string Slug { get; set; }
        public string Topic { get; set; }
        public Instant Published { get; set; }
        public string Content { get; set; }
        public string AuthorName { get; set; }
    }
}
