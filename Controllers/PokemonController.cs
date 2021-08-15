using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PokemonMysteryDungeonNPCGenerator.Models;

namespace PokemonMysteryDungeonNPCGenerator.Controllers
{
    public class PokemonController : Controller
    {
        //private PokemonMysteryDungeonNPCGeneratorContext db = new PokemonMysteryDungeonNPCGeneratorContext();

        // GET: Pokemon
        public ActionResult Index()
        {
            return View();
        }

        

        // GET: Pokemon/Create
        public ActionResult Create()
        {
            return View();
        }

        

    }
}
