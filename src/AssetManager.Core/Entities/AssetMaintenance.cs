﻿using AssetManager.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManager.Core.Entities
{
    public class AssetMaintenance: Entity
    {

        [ForeignKey("Asset")]
        public int AssetId { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }

        public string AssetMaintanceType { get; set; }
        public string Title { get; set; }
        public bool IsWarranty { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public int AssetMaintanceTime { get; set; }
        public string Note { get; set; }
        public decimal Cost { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public int UserId { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
