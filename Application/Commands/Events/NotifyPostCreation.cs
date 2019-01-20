using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Events
{
    public class NotifyPostCreation : INotification
    {
        public NotifyPostCreation(Post post)
        {
            Post = post;
        }
        public Post Post { get; }
    }
}
