using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;


namespace WebApplication3.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
            
            
        {
            List<UserModel> users = new List<UserModel>();
            UserModel u1 = new UserModel("Crystal", "Crystal@net.net", "0000000000");
            UserModel u2 = new UserModel("Mike", "Mike@net.net", "1111111111");
            UserModel u3 = new UserModel("Lily", "Lily@net.net", "2222222222");
            UserModel u4 = new UserModel("Rogan", "Rogan@net.net", "3333333333");

            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);
            Console.WriteLine(users);
            



            return View("Test",users);
        }
    }
}