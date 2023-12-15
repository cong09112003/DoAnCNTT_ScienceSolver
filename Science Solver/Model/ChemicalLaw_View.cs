namespace Science_Solver.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ChemicalLaw_View
    {
        [Key]
        [Column(Order = 0)]
        public int Number { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Content { get; set; }

        [Key]
        [Column(Order = 3)]
        public string FORMULA { get; set; }
    }
}
