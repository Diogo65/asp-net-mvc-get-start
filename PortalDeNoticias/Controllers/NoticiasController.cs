using PortalDeNoticias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalDeNoticias.Controllers
{
    public class NoticiasController : Controller
    {
        // GET: Noticias
        public ActionResult Index()
        {
  

            return View(RepositorioNoticias.Noticias);
        }

        public ActionResult Details(int id)
        {
            //ViewBag: usamos esse mecanismo para passar informações secundárias para a view, tais como mensagens, dados de paginação, notificações, etc.
            ViewBag.Mensagem = "Atenção Atenção view bag";

            //realiza umj filtro por id
            //esse metodo vai iterar sobre a lista de noticias, e para cada objeto n dentro dessa lista ele vai 
            //verificar qual dele atende ao filtro, e o primeiro que corresponder será passado para a var noticia
            var noticia = RepositorioNoticias.Noticias.FirstOrDefault(n => n.Id == id); //n representa um objeto noticia dentro dessa lista
           
            return View(noticia); //retorna a var noticia para a view
        }

        public ActionResult Buscar(string texto)
        {
            var noticias = RepositorioNoticias.Noticias.Where(n => n.Titulo.Contains(texto) || n.Conteudo.Contains(texto));
            return View(noticias);
        }

        
    }
}