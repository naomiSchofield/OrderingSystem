using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; //controller is inside of the MVC. 
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MCV_APP.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/


        //GET: the Index in the VIEW folder. 
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Goodbye(string name)
        {
            
            ViewData["GoodByeMessage"] = $"Goodbye, {name}";
            return View();
        }

        //get, post, update and delete.

        public IActionResult POST ()
        {

        }

        /* 
         * https://localhost:{PORT}/Hello/
         */

        //This is our get => GET:/Hello/ Index is the same as '/'
        //index takes us to Hello because we're inside the hello Controller file. 
        //public string Index()  //our home for the Controller.
        //{
        //    return "This is my go to page for the Controller, yo.";
        //}
        //This is going to GET: /Hello/Wassup => This is a subview (inside) the controller.

        public string Wassup()
        {
            return "Wassssup!";

        }
        //This is a GET: /Hello/Demo => https://localhost:5001/Hello/Demo

        public string DEMO(string name, int ID)
        {
        //name = "Jacob";
        //ID = 1;
        //We CAN USE A QUERY STRING IN THE HTTP to change the value of name and ID.
        //https://localhost:5001/Hello/Demo?name=Charmaine&ID=2



            return HtmlEncoder.Default.Encode($"Hello, {name}. Your ID number is: {ID}");
        }

    }
}
