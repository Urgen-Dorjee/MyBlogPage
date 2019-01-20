using Microsoft.AspNetCore.Identity;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Author : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private List<Post> _posts { get; } = new List<Post>();
        public IReadOnlyCollection<Post> Posts => _posts.AsReadOnly();

        public void AddPost(string topic, string content, Instant published, string slug)
        {
            if (!Posts.Any(p => p.Topic != topic))
            {
                _posts.Add(new Post()
                {
                    Topic = topic,
                    Content = content,
                    Published = published,
                    Slug = slug
                });
            }
        }
    }
}
