//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gestionHotel.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gestionHotelEntities2 : DbContext
    {
        public gestionHotelEntities2()
            : base("name=gestionHotelEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Chambre> Chambre { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Facture> Facture { get; set; }
        public virtual DbSet<Service> Service { get; set; }
    }
}
