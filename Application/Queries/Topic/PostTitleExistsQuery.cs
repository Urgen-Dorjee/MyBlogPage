using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Topic
{
    public class PostTitleExistsQuery : IRequest<bool>
    {
        public string Slug { get; set; }
        public int Id { get; set; }
    }
}
