using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class RepositorioNoticias
    {
        private static List<Noticia> noticias;

        public static List<Noticia> Noticias
        {
            get
            {
                if (noticias == null)
                    CriarNoticias();
                return noticias;
            }
        }

        private static void CriarNoticias()
        {
            noticias = new List<Noticia>();

            noticias.Add(new Noticia
            {
                Id = 1,
                Titulo = "Loren Ipslum",
                Autor = "Diogo S.O",
                Data = DateTime.Today,
                Conteudo = "Lorem ipsum dabliou xix ve ene eme opeq eree esse t uhu ve dabliow xix epsloum ve"
            });

            noticias.Add(new Noticia
            {
                Id = 2,
                Titulo = "Loren Ipslum",
                Autor = "Diogo S.O",
                Data = DateTime.Today,
                Conteudo = "Lorem ipsum dabliou xix ve ene eme opeq eree esse t uhu ve dabliow xix epsloum ve"
            });

            noticias.Add(new Noticia
            {
                Id = 3,
                Titulo = "Loren Ipslum",
                Autor = "Diogo S.O",
                Data = DateTime.Today,
                Conteudo = "Lorem ipsum dabliou xix ve ene eme opeq eree esse t uhu ve dabliow xix epsloum ve"
            });

            noticias.Add(new Noticia
            {
                Id = 4,
                Titulo = "Loren Ipslum",
                Autor = "Diogo S.O",
                Data = DateTime.Today,
                Conteudo = "Lorem ipsum dabliou xix ve ene eme opeq eree esse t uhu ve dabliow xix epsloum ve"
            });

            noticias.Add(new Noticia
            {
                Id = 5,
                Titulo = "Loren Ipslum",
                Autor = "Diogo S.O",
                Data = DateTime.Today,
                Conteudo = "Lorem ipsum dabliou xix ve ene eme opeq eree esse t uhu ve dabliow xix epsloum ve"
            });
        }
    }
}