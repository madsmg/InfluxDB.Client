﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vibrant.InfluxDB.Client
{
   [AttributeUsage( AttributeTargets.Property, Inherited = false, AllowMultiple = false )]
   public sealed class InfluxFieldAttribute : Attribute
   {
      private readonly string _name;

      public InfluxFieldAttribute( string name )
      {
         _name = name;
      }

      public string Name
      {
         get { return _name; }
      }
   }
}