using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emse.KMSPortal.Controllers
{
    public class LoginController : Controller
    {
        //TODO: Parametre ile kontrol edilip hatalı giriş mesajı verilecek
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logout()
        {
            //Session.SessionID = String.Empty;
            Session["UserSession"] = null;
            return RedirectToAction(nameof(Index));
        }

        //TODO: Ekrandan kullanıcı adı ve şifre model sınıfı parametre geçilecek
        public ActionResult LogIn()
        {
            //var userInfoCheckResult = servisten.metotcagir(parametregec);
            //if(userInfoCheckResult == null || !userInfoCheckResult.LoginResult)
            //{
            //    return RedirectToAction(nameof(Index));
            //}
            //else
            //{
            //    Session["UserSession"] = userInfoCheckResult.UserSession;
            //    return RedirectToAction("/Home/Index");
            //}
            return RedirectToAction("Index","Home");
        }
    }
}