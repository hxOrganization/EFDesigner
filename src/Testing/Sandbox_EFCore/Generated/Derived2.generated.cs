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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Sandbox_EFCore
{
   public partial class Derived2: global::Sandbox_EFCore.BaseClass
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected Derived2(): base()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="name"></param>
      /// <param name="symbol"></param>
      /// <param name="required"></param>
      public Derived2(string name, string symbol, global::Sandbox_EFCore.Derived required)
      {
         if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
         this.Name = name;
         if (string.IsNullOrEmpty(symbol)) throw new ArgumentNullException(nameof(symbol));
         this.Symbol = symbol;
         if (required == null) throw new ArgumentNullException(nameof(required));
         this.Required = required;

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="name"></param>
      /// <param name="symbol"></param>
      /// <param name="required"></param>
      public static Derived2 Create(string name, string symbol, global::Sandbox_EFCore.Derived required)
      {
         return new Derived2(name, symbol, required);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Indexed, Required
      /// </summary>
      [Required]
      public string Name { get; set; }

      /// <summary>
      /// Indexed, Required
      /// </summary>
      [Required]
      public string Symbol { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

      public virtual global::Sandbox_EFCore.Derived Optional { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Sandbox_EFCore.Derived Required { get; set; }

   }
}

