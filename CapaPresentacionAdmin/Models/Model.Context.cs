﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaPresentacionAdmin.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FabricaCalzadosDB : DbContext
    {
        public FabricaCalzadosDB()
            : base("name=FabricaCalzadosDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alerta> Alerta { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Defecto> Defecto { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<JornadaLaboral> JornadaLaboral { get; set; }
        public virtual DbSet<Linea> Linea { get; set; }
        public virtual DbSet<Modelo> Modelo { get; set; }
        public virtual DbSet<ModeloColor> ModeloColor { get; set; }
        public virtual DbSet<OrdenProduccion> OrdenProduccion { get; set; }
        public virtual DbSet<Registro> Registro { get; set; }
        public virtual DbSet<Turno> Turno { get; set; }
    }
}
