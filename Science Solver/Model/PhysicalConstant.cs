namespace Science_Solver.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhysicalConstant")]
    public partial class PhysicalConstant
    {
        [Key]
        public int Number { get; set; }

        [Required]
        [StringLength(10)]
        public string Symbol { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string VALUE { get; set; }

        [Required]
        [StringLength(20)]
        public string UNIT { get; set; }
    }
}
