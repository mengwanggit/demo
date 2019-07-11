using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bll.Interface;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        private IUser _userBll;
        public UserController(IUser userBll)
        {
            _userBll = userBll;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            string name = _userBll.GetName(1);
            return View();
        }
    }
}