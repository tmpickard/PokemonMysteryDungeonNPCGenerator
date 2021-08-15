using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
        [HttpGet]
        [Route("/pokemon")]
        public ActionResult Index()
        {
            
            return View();
        }

        

        // GET: Pokemon/Create
        [HttpGet]
        [Route("/pokemon/create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Pokemon Pokemon)
        {
            return Redirect("/pokemon");
        }

    }
}
