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
    public class ChemicalLawLinq
    {
        public DataTable getAllPhysicalLaw()
        {
            try
            {
                using (var db = new ScienceSolverModels())
                {
                    var query = from q in db.ChemicalLaws
                                select q;
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Number", typeof(int));
                    dt.Columns.Add("Name", typeof(string));
                    dt.Columns.Add("Content", typeof(string));
                    dt.Columns.Add("Formula", typeof(string));
                    foreach (var item in query)
                    {
                        DataRow row = dt.NewRow();
                        row["Number"] = item.Number;
                        row["Name"] = item.Name;
                        row["Content"] = item.Content;
                        row["Formula"] = item.FORMULA;
                        dt.Rows.Add(row);
                    }
                    return dt;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return new DataTable();
        }
        public DataTable getPhysicalFormulaByInfor(string Infor)
        {
            try
            {
                int resNumb;
                bool success = int.TryParse(Infor, out resNumb);

                DataTable dt = new DataTable();

                using (var db = new ScienceSolverModels())
                {
                    if (!success)
                    {
                        var query = from q in db.ChemicalLaws
                                    where q.Name.Contains(Infor) || q.Content.Contains(Infor)
                                    select q;
                        dt.Columns.Add("Number", typeof(int));
                        dt.Columns.Add("Name", typeof(string));
                        dt.Columns.Add("Content", typeof(string));
                        dt.Columns.Add("Formula", typeof(string));
                        foreach (var item in query)
                        {
                            DataRow row = dt.NewRow();
                            row["Number"] = item.Number;
                            row["Name"] = item.Name;
                            row["Content"] = item.Content;
                            row["Formula"] = item.FORMULA;
                            dt.Rows.Add(row);
                        }
                    }
                    else
                    {
                        var query = from q in db.PhysicalLaws
                                    where q.Number == resNumb
                                    select q;
                        dt.Columns.Add("Number", typeof(int));
                        dt.Columns.Add("Name", typeof(string));
                        dt.Columns.Add("Content", typeof(string));
                        dt.Columns.Add("Formula", typeof(string));
                        foreach (var item in query)
                        {
                            DataRow row = dt.NewRow();
                            row["Number"] = item.Number;
                            row["Name"] = item.Name;
                            row["Content"] = item.Content;
                            row["Formula"] = item.Formula;
                            dt.Rows.Add(row);
                        }
                    }
                    return dt;
                };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return new DataTable();
        }
    }
}
