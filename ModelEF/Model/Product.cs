namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [StringLength(100)]
        public string ID { get; set; }

        [StringLength(100)]
        public string IDCategory { get; set; }

        [Required]
        [StringLength(150)]
        public string NameProduct { get; set; }

        public decimal UnitCost { get; set; }

        public int? Quantity { get; set; }

        [StringLength(150)]
        public string ImageProduct { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [StringLength(100)]
        public string StatusProduct { get; set; }

        public virtual Category Category { get; set; }
    }
}
