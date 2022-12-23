﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using warehouseManagement.Entities.Base;

namespace warehouseManagement.NewFolder
{
    class Receivings
    {
        [Key]
        public int ReceivingId { get; set; }
        public DateTime ReceivingDate { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public Suppliers Supplier { get; set; }

        public ICollection<ReceivingItem> ReceivingItems { get; set; }
    }
}
