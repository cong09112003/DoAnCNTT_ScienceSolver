namespace Science_Solver.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ChemicalElement_View
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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
        public double AtomicMass { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Configuration { get; set; }

        [Key]
        [Column(Order = 5)]
        public double Electronegativity { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Oxidation { get; set; }
    }
}
