using FormsWithHttpPost.DAL;
using FormsWithHttpPost.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormsWithHttpPost.Controllers
{
    public class HomeController : Controller
    {
        IReviewDAL dal;

        public HomeController()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["SquirrelReviews"].ConnectionString;
            dal = new ReviewSqlDAL(connectionstring);

        }

        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            List<Review> reviews = dal.GetAllReviews();
            return View(reviews);
        }

        // Get: Blank Review Form
        [HttpGet]
        public ActionResult Form()
        {
            return View();
        }

        //Submitting Completed Form
        [HttpPost]
        public ActionResult Submission(Review newReview)
        {
            // code that calls DAL
            // Save the Review
            dal.SaveReview(newReview);

            return RedirectToAction("Index", "Home");

            // for Post-Redirect-Get pattern....
            // Redirect the user to another Controller Action
        }

    }
}