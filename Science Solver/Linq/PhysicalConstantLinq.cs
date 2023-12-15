using Science_Solver.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Science_Solver.Linq
{
    public class PhysicalConstantLinq
    {
        public DataTable getAllPhysicalConstant()
        {
            try
            {
                using (var db = new ScienceSolverModels())
                {
                    var query = from q in db.PhysicalConstants
                                select q;
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Number", typeof(int));
                    dt.Columns.Add("Symbol", typeof(string));
                    dt.Columns.Add("Name", typeof(string));
                    dt.Columns.Add("VALUE", typeof(string));
                    dt.Columns.Add("UNIT", typeof(string));
                    foreach (var item in query)
                    {
                        DataRow row = dt.NewRow();
                        row["Number"] = item.Number;
                        row["Symbol"]=item.Symbol;
                        row["Name"] = item.Name;
                        row["VALUE"] = item.VALUE;
                        row["UNIT"] = item.UNIT;
                        dt.Rows.Add(row);
                    }
                    return dt;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            return new DataTable();
        }
        public DataTable getPhysicalConstantBySign(string symbol)
        {
            try
            {
                using (var db = new ScienceSolverModels())
                {
                    var query = from q in db.PhysicalConstants
                                where q.Symbol.Contains(symbol)
                                select q;
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Number", typeof(int));
                    dt.Columns.Add("Symbol", typeof(string));
                    dt.Columns.Add("Name", typeof(string));
                    dt.Columns.Add("VALUE", typeof(string));
                    dt.Columns.Add("UNIT", typeof(string));
                    foreach(var item in query) 
                    {
                        DataRow row = dt.NewRow();
                        row["Number"] = item.Number;
                        row["Symbol"] = item.Symbol;
                        row["Name"] = item.Name;
                        row["VALUE"] = item.VALUE;
                        row["UNIT"] = item.UNIT;
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
        public DataTable getPhysicalConstantByName(string name)
        {
            try
            {
                using (var db = new ScienceSolverModels())
                {
                    var query = from q in db.PhysicalConstants
                                where q.Name.Contains(name)
                                select q;
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Number", typeof(int));
                    dt.Columns.Add("Symbol", typeof(string));
                    dt.Columns.Add("Name", typeof(string));
                    dt.Columns.Add("VALUE", typeof(string));
                    dt.Columns.Add("UNIT", typeof(string));
                    foreach (var item in query)
                    {
                        DataRow row = dt.NewRow();
                        row["Number"] = item.Number;
                        row["Symbol"] = item.Symbol;
                        row["Name"] = item.Name;
                        row["VALUE"] = item.VALUE;
                        row["UNIT"] = item.UNIT;
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
    }
}
