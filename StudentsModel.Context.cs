namespace ПМ._07_Соадминистрирование
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StudentsEntities : DbContext
    {
        public StudentsEntities()
            : base("name=StudentsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Оценки> Оценки { get; set; }
        public virtual DbSet<Предметы> Предметы { get; set; }
        public virtual DbSet<Специальности> Специальности { get; set; }
        public virtual DbSet<Студенты> Студенты { get; set; }
    }
}
