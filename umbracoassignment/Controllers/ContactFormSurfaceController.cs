using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using umbracoassignment.ViewModels;

namespace umbracoassignment.Controllers 
{
    public class ContactFormSurfaceController : Umbraco.Web.Mvc.SurfaceController
    {
        public ActionResult Index(){
            return PartialView("ContactForm", new ContactForm());
        }
    }
}