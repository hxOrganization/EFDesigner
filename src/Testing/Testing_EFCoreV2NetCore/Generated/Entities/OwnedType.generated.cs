//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
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

namespace Testing
{
   public partial class OwnedType
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public OwnedType()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_allpropertytypesoptional0"></param>
      public OwnedType(global::Testing.AllPropertyTypesOptional _allpropertytypesoptional0)
      {
         if (_allpropertytypesoptional0 == null) throw new ArgumentNullException(nameof(_allpropertytypesoptional0));
         _allpropertytypesoptional0.OwnedType = this;

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_allpropertytypesoptional0"></param>
      public static OwnedType Create(global::Testing.AllPropertyTypesOptional _allpropertytypesoptional0)
      {
         return new OwnedType(_allpropertytypesoptional0);
      }

      /*************************************************************************
       * Persistent properties
       *************************************************************************/

      public Single? SingleAttr { get; set; }

      /*************************************************************************
       * Persistent navigation properties
       *************************************************************************/

   }
}
