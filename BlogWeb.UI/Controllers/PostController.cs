using Application.Queries.GetAllPosts;
using Application.Queries.GetPost;
using BlogWeb.UI.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWeb.UI.Controllers
{
    public class PostController : BaseController
    {
        
        public async Task<IActionResult> Index()
        {
            var number = 2;
            return View(await Mediator.Send(new GetAllPostsQuery(number)));

        }

        [HttpGet("{slug}")]
        public async Task<IActionResult> GetPost(string slug)
        {
            return View(await Mediator.Send(new GetPostQuery(slug)));
        }


        public IActionResult Privacy()
        {
            return View();
        }
    }
}
