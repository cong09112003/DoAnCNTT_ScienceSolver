namespace Science_Solver.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ChemicalConstant_View
    {
        [Key]
        [Column(Order = 0)]
        public int Number { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Symbol { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string Value { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string UNIT { get; set; }
    }
}
