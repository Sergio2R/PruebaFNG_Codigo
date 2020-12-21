using AppPruebaFNG_Solucion.Models;
using BusinessLogic;
using BusinessLogic.Models;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace FNGPrueba_Solucion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ServerInformer serverInformer = new ServerInformer();
            ServerInformation serverInformation = serverInformer.GetServerInformation();

            ViewBag.fechaServidor = serverInformation.ServerDate;
            ViewBag.horaServidor = serverInformation.ServerHour;
            ViewBag.ipServidorPrivada = serverInformation.PrivateIpServer;
            ViewBag.ipServidorPublica = serverInformation.PublicIpServer;
            ViewBag.countryName = serverInformation.CountryName;
            ViewBag.regionName = serverInformation.RegionName;
            ViewBag.cityName = serverInformation.CityName;

            return View();
        }

    }
}