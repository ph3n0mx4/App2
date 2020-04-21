﻿using CarSalesApp.Data.Models;
using CarSalesApp.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesApp.Web.ViewModels.Cars
{
    public class ModelInputViewModel : IMapFrom<Model>
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public int ModelId { get; set; }

        public virtual Make Make { get; set; }
    }
}
