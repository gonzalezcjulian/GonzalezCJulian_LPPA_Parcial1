using LPPA_Parcial1.Site.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LPPA_Parcial1.Site.Services
{
    public class AfiliadoRepository
    {
        public List<Afiliado> ObtenerTodos()
        {
            using (var db = new AfiliadoContext())
            {
                return db.Afiliados.ToList();
            }
        }

        public void Crear(Afiliado model)
        {
            using (var db = new AfiliadoContext())
            {
                db.Afiliados.Add(model);
                db.SaveChanges();
            }
        }
        public void Editar(Afiliado model)
        {
            using (var db = new AfiliadoContext())
            {
                var entity = db.Afiliados.Find(model.Id);
                entity.Id = model.Id;
                entity.Nombre = model.Nombre;
                entity.Apellido = model.Apellido;
                entity.Email = model.Email;
                entity.Telefono = model.Telefono;
                entity.CUIT = model.CUIT;
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Eliminar(Afiliado model)
        {
            using (var db = new AfiliadoContext())
            {
                var entity = db.Afiliados.Find(model.Id);
                db.Afiliados.Remove(entity);
                db.SaveChanges();
            }
        }

        //public void Get(Afiliado model)
        //{
        //    using (var db = new AfiliadoContext())
        //    {
        //        var entity = db.Afiliados.Find(model.Id);
        //        entity.Id = model.Id;
        //        entity.Nombre = model.Nombre;
        //        entity.Apellido = model.Apellido;
        //        entity.Email = model.Email;
        //        entity.Telefono = model.Telefono;
        //        entity.CUIT = model.CUIT;
        //        db.Entry(entity).State = EntityState.Modified;
        //        db.SaveChanges();
        //    }
        //}
    }
}