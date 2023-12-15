using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Science_Solver.Model
{
    public partial class ScienceSolverModels : DbContext
    {
        public ScienceSolverModels()
            : base("name=ScienceSolverModels")
        {
        }

        public virtual DbSet<ChemicalConstant> ChemicalConstants { get; set; }
        public virtual DbSet<ChemicalElement> ChemicalElements { get; set; }
        public virtual DbSet<ChemicalEquation> ChemicalEquations { get; set; }
        public virtual DbSet<ChemicalLaw> ChemicalLaws { get; set; }
        public virtual DbSet<MathematicalLaw> MathematicalLaws { get; set; }
        public virtual DbSet<MathematicalTheorem> MathematicalTheorems { get; set; }
        public virtual DbSet<PhysicalConstant> PhysicalConstants { get; set; }
        public virtual DbSet<PhysicalFormula> PhysicalFormulas { get; set; }
        public virtual DbSet<PhysicalLaw> PhysicalLaws { get; set; }
        public virtual DbSet<ChemicalConstant_View> ChemicalConstant_View { get; set; }
        public virtual DbSet<ChemicalElement_View> ChemicalElement_View { get; set; }
        public virtual DbSet<ChemicalEquation_View> ChemicalEquation_View { get; set; }
        public virtual DbSet<ChemicalLaw_View> ChemicalLaw_View { get; set; }
        public virtual DbSet<MathematicalLaw_View> MathematicalLaw_View { get; set; }
        public virtual DbSet<MathematicalTheorem_View> MathematicalTheorem_View { get; set; }
        public virtual DbSet<PhysicalConstant_View> PhysicalConstant_View { get; set; }
        public virtual DbSet<PhysicalFormula_View> PhysicalFormula_View { get; set; }
        public virtual DbSet<PhysicalLaw_View> PhysicalLaw_View { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChemicalConstant>()
                .Property(e => e.Symbol)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalConstant>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalConstant>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalConstant>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalElement>()
                .Property(e => e.Symbol)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalElement>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalElement>()
                .Property(e => e.Configuration)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalElement>()
                .Property(e => e.Oxidation)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalEquation>()
                .Property(e => e.Precursors)
                .IsUnicode(false);

            modelBuilder.Entity<MathematicalTheorem>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalConstant>()
                .Property(e => e.Symbol)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalConstant>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalConstant>()
                .Property(e => e.VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalConstant>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalConstant_View>()
                .Property(e => e.Symbol)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalConstant_View>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalConstant_View>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalConstant_View>()
                .Property(e => e.UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalElement_View>()
                .Property(e => e.Symbol)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalElement_View>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalElement_View>()
                .Property(e => e.Configuration)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalElement_View>()
                .Property(e => e.Oxidation)
                .IsUnicode(false);

            modelBuilder.Entity<ChemicalEquation_View>()
                .Property(e => e.Precursors)
                .IsUnicode(false);

            modelBuilder.Entity<MathematicalTheorem_View>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalConstant_View>()
                .Property(e => e.Symbol)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalConstant_View>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalConstant_View>()
                .Property(e => e.VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalConstant_View>()
                .Property(e => e.UNIT)
                .IsUnicode(false);
        }
    }
}
