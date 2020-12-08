using Aula05.DAO;
using Aula05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula05.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            ProdutoDAO dao = new ProdutoDAO();
            IList<Produto> produtos = dao.Lista();
            ViewBag.Produtos = produtos;
            return View();
        }
    }
}