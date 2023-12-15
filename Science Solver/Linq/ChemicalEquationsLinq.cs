using Science_Solver.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Science_Solver.Linq
{
    public class ChemicalEquationsLinq
    {
        public DataTable getAllChemicalEquations()
        {
            try
            {
                using (var db = new ScienceSolverModels())
                {
                    var query = from q in db.ChemicalEquation_View
                                select q;
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Number", typeof(int));
                    dt.Columns.Add("Precursors", typeof(string));
                    dt.Columns.Add("ChemicalEquation", typeof(string));
                    foreach(var item in query)
                    {
                        DataRow row = dt.NewRow();
                        row["Number"] = item.Number;
                        row["Precursors"] = item.Precursors;
                        row["ChemicalEquation"] = item.ChemicalEquation;
                        dt.Rows.Add(row);
                    }
                    return dt;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            return new DataTable();
        }
        public ChemicalEquation  GetChemicalEquationsByPrecursors(string Precursors)
        {
            try
            {
                using (var db = new ScienceSolverModels())
                {
                    var query = from q in db.ChemicalEquations
                                where q.Precursors.ToLower().Contains(Precursors.ToLower())
                                select new 
                                {
                                    Number = q.Number,
                                    Precursors = q.Precursors,
                                    ChemicalEquation1 = q.ChemicalEquation1
                                };
                    var res = query.FirstOrDefault();
                    if(res != null) 
                    {
                        var ChemicalEquation = new ChemicalEquation
                        {
                            Number = res.Number,
                            Precursors = res.Precursors,
                            ChemicalEquation1 = res.ChemicalEquation1
                        };
                        return ChemicalEquation;
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            return new ChemicalEquation();
        }
    }
}
