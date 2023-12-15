namespace Science_Solver.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MathematicalLaw")]
    public partial class MathematicalLaw
    {
        [Key]
        public int Number { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string FORMULA { get; set; }
    }
}
