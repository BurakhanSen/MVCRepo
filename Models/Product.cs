using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCTest.Models.ModelMetadataTypes;

namespace MVCTest.Models
{
    //[ModelMetadataType(typeof(ProductMetada))]
    public class Product
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }
    }
}
