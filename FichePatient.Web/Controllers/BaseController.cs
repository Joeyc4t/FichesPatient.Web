using FichePatient.DAL.UnitOfWork;
using System.Web.Mvc;

namespace FichePatient.Web.Controllers
{
    public class BaseController : Controller
    {
        protected UnitOfWork UOW = new UnitOfWork();
    }
}