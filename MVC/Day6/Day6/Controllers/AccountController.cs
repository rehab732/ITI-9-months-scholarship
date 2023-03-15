using Day6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Day6.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            //check modelstate.isvalid
            //inseert into db
            //create identity using claim
            //use owin middelware
            //then use user identity to create cookie for this user
            // redirect to home index
            if(ModelState.IsValid)
            {
                MainDbContext context=new MainDbContext();
                context.users.Add(user);
                context.SaveChanges();
                var userIdentity = new ClaimsIdentity(new List<Claim>()
                {
                    new Claim("Name",user.Name),
                    new Claim(ClaimTypes.Email,user.Email),
                    new Claim("Password",user.Password)



                }, "AppCookie");


                //get owin auth manager
                Request.GetOwinContext().Authentication.SignIn(userIdentity);
                return RedirectToAction("Index", "Home");
            }
         


            return View();
        }
        public ActionResult Login()
        {
          
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            //get user from db
            //check user not null
            //if not null
            //get owin and login
            //else return view 
            MainDbContext context = new MainDbContext();
            var loggeduser=context.users.FirstOrDefault(x => x.Email== user.Email&&x.Password==user.Password);
            if(loggeduser!=null)
            {
                var signinidentity = new ClaimsIdentity(new List<Claim>()
                {
                    new Claim(ClaimTypes.Email,user.Email),
                    new Claim("Password",user.Password)
                }, "AppCookie");
                //get owin auth manager
                Request.GetOwinContext().Authentication.SignIn(signinidentity);
                return RedirectToAction("Index", "Home");



            }
            else
            {
                ModelState.AddModelError("Name", "User Not Existed");
            return View();

            }



        }
        public ActionResult Logout()
        {
            //destroy cooki for this user
            Request.GetOwinContext().Authentication.SignOut("AppCookie");
            return RedirectToAction("Login");


        }
        [HttpPost]
        public ActionResult Logout(User user)
        {

            return View();
        }
    }
}