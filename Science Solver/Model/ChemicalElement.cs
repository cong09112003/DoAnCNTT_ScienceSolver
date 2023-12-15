namespace Science_Solver.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChemicalElement")]
    public partial class ChemicalElement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Number { get; set; }

        [Required]
        [StringLength(10)]
        public string Symbol { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public double AtomicMass { get; set; }

        [Required]
        [StringLength(50)]
        public string Configuration { get; set; }

        public double Electronegativity { get; set; }

        [Required]
        [StringLength(50)]
        public string Oxidation { get; set; }
    }
}
