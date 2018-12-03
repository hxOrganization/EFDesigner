//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor
//     https://github.com/msawczyn/EFDesigner
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace Sandbox
{
   /// <inheritdoc/>
   public partial class EFModel1 : System.Data.Entity.DbContext
   {
      #region DbSets
      public System.Data.Entity.DbSet<Sandbox.Entity1> Entity1 { get; set; }
      public System.Data.Entity.DbSet<Sandbox.Entity2> Entity2 { get; set; }
      #endregion DbSets

      /// <summary>
      /// Default connection string
      /// </summary>
      public static string ConnectionString { get; set; } = @"Data Source=localhost;Initial Catalog=ModelTest;Integrated Security=True";
      /// <inheritdoc />
      public EFModel1() : base(ConnectionString)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFModel1>(new EFModel1DatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public EFModel1(string connectionString) : base(connectionString)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFModel1>(new EFModel1DatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public EFModel1(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFModel1>(new EFModel1DatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public EFModel1(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFModel1>(new EFModel1DatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public EFModel1(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFModel1>(new EFModel1DatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public EFModel1(System.Data.Entity.Infrastructure.DbCompiledModel model) : base(model)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFModel1>(new EFModel1DatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public EFModel1(System.Data.Entity.Core.Objects.ObjectContext objectContext, bool dbContextOwnsObjectContext) : base(objectContext, dbContextOwnsObjectContext)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFModel1>(new EFModel1DatabaseInitializer());
         CustomInit();
      }

      partial void CustomInit();
      partial void OnModelCreatingImpl(System.Data.Entity.DbModelBuilder modelBuilder);
      partial void OnModelCreatedImpl(System.Data.Entity.DbModelBuilder modelBuilder);

      /// <inheritdoc />
      protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);
         OnModelCreatingImpl(modelBuilder);

         modelBuilder.HasDefaultSchema("dbo");

         modelBuilder.Entity<Sandbox.Entity1>()
                     .ToTable("Entity1")
                     .HasKey(t => t.Id);
         modelBuilder.Entity<Sandbox.Entity1>()
                     .Property(t => t.Id)
                     .IsRequired()
                     .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute()))
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
         modelBuilder.Entity<Sandbox.Entity1>()
                     .Property(t => t.Timestamp)
                     .IsRequired()
                     .IsRowVersion();
         modelBuilder.Entity<Sandbox.Entity1>()
                     .HasMany(x => x.Entity2)
                     .WithRequired()
                     .Map(x => x.MapKey("Entity1_Id"));
         modelBuilder.Entity<Sandbox.Entity1>()
                     .HasRequired(x => x.Entity2_1)
                     .WithMany(x => x.Entity1)
                     .Map(x => x.MapKey("Entity2_1_Id"));

         modelBuilder.Entity<Sandbox.Entity2>()
                     .ToTable("Entity2")
                     .HasKey(t => t.Id);
         modelBuilder.Entity<Sandbox.Entity2>()
                     .Property(t => t.Id)
                     .IsRequired()
                     .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute()))
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
         modelBuilder.Entity<Sandbox.Entity2>()
                     .Property(t => t.Timestamp)
                     .IsRequired()
                     .IsRowVersion();
         modelBuilder.Entity<Sandbox.Entity2>()
                     .HasOptional(x => x.Entity1_1)
                     .WithOptionalPrincipal(x => x.Entity2_2);

         OnModelCreatedImpl(modelBuilder);
      }
   }
}