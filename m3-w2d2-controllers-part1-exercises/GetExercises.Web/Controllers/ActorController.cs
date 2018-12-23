using GetExercises.Web.DAL.Interfaces;
using GetExercises.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetExercises.Web.Controllers
{
    public class ActorController : Controller
    {
        private IActorDAL dal;
        // EAU - is above supposed to be private? Example has no private/public association
        /// <summary>
        /// The MVC framework with the assistance of Ninject, automatically passes in a ActorDAL.
        /// </summary>
        /// <param name="dal"></param>
        public ActorController(IActorDAL dal)
        {
            this.dal = dal;
        }
        
        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// The request to display search results.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        /// <returns></returns>
        //public ActionResult SearchResult(/*ActorSearch request */)
        public ActionResult SearchResult(string Name)
        {
            /* Call the DAL and pass the values as a model back to the View */
            //return null;
            IList<Actor> actorList = dal.FindActors(Name);
           
            return View("SearchResult", actorList);
        }
    }
}