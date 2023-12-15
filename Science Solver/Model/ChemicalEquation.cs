namespace Science_Solver.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChemicalEquation")]
    public partial class ChemicalEquation
    {
        [Key]
        public int Number { get; set; }

        [Required]
        [StringLength(50)]
        public string Precursors { get; set; }

        [Column("ChemicalEquation")]
        [Required]
        public string ChemicalEquation1 { get; set; }
    }
}
