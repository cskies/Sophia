using Sophia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sophia.DAO
{
    public class RegistrosDAO
    {
        public void Adiciona(Registro registro)
        {
            using (var context = new SophiaContext())
            {
                context.Registros.Add(registro);
                context.SaveChanges();
            }
        }

        public IList<Registro> Lista()
        {
            using (var context = new SophiaContext())
            {
                return context.Registros.Include("Instituicao").ToList();
            }
        }

        public void Atualiza(Registro registro)
        {
            using (var context = new SophiaContext())
            {
                context.Entry(registro).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}