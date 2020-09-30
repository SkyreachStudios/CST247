using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ButtonController : Controller



    {
       static List<ButtonModel> buttons = new List<ButtonModel>();
        // GET: Button
        public ActionResult Index()
        {
            

            ButtonModel b1 = new ButtonModel(true);
            ButtonModel b2 = new ButtonModel(true);

            buttons.Add(b1);
            buttons.Add(b2);


            return View("Button",buttons);
        }


       [HttpPost]
        public ActionResult OnButtonClick(string mine)
        {
            Console.Write("Accessed button click!!");
            if(mine.Equals("1"))
            {
                if(!buttons[0].State)
                {
                    buttons[0].State = true;
                }
                else
                {
                    buttons[0].State = false;

                }
                


            }
            else if (mine.Equals("2"))
            {
                if (!buttons[1].State)
                {
                    buttons[1].State = true;
                }
                else
                {
                    buttons[1].State = false;

                }

                
            }

            return View("Button", buttons);
        }
    }
}