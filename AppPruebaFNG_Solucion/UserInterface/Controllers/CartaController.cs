using AppPruebaFNG_Solucion.Models;
using BusinessLogic;
using BusinessLogic.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FNGPrueba_Solucion.Controllers
{
    public class CartaController : Controller
    {
        // GET: Carta
        public ActionResult Redactar()
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


            DataConnectionManager data = new DataConnectionManager();
            List<Tratamiento> tratamientos = data.GetTratamientos();
            List<Despedida> despedidas = data.GetDespedidas();
            List<Cargo> cargos = data.GetCargos();

            ViewBag.tratamientos = tratamientos;
            ViewBag.despedidas = despedidas;
            ViewBag.cargos = cargos;
            return View();
        }
    }
}