using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.DATAACCESS;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MovieController : Controller
    {


        public ActionResult Index()
        {
            //return View(ll);
            MovieDAL movieDAL = new MovieDAL();

            movieDAL.show();

            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

    }
}