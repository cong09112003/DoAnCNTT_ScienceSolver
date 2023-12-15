using Science_Solver.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace Science_Solver.Linq
{
    public class ChemicalElementLinq
    { 
        public DataTable getAllChemicalElement()
        {
            try
            {
                using (var db = new ScienceSolverModels())
                {
                    var query = from q in db.ChemicalElement_View
                                select q;
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Number", typeof(int));
                    dt.Columns.Add("Symbol", typeof(string));
                    dt.Columns.Add("Name", typeof(string));
                    dt.Columns.Add("AtomicMass", typeof(double));
                    dt.Columns.Add("Configuration", typeof(string));
                    dt.Columns.Add("Electronegativity", typeof(double));
                    dt.Columns.Add("Oxidation", typeof(string));
                    foreach (var item in query)
                    {
                        DataRow row = dt.NewRow();
                        row["Number"] = item.Number;
                        row["Symbol"] = item.Symbol;
                        row["Name"] = item.Name;
                        row["AtomicMass"] = item.AtomicMass;
                        row["Configuration"] = item.Configuration;
                        row["Electronegativity"] = item.Electronegativity;
                        row["Oxidation"] = item.Oxidation;
                        dt.Rows.Add(row);
                    }
                    return dt;  
                };
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return new DataTable();
        }
        public DataTable getChemicalElementByNumber(int num)
        {
            try
            {
                using (var db = new ScienceSolverModels())
                {
                    var query = from q in db.ChemicalElement_View
                                where q.Number == num
                                select q;
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Number", typeof(int));
                    dt.Columns.Add("Symbol", typeof(string));
                    dt.Columns.Add("Name", typeof(string));
                    dt.Columns.Add("AtomicMass", typeof(double));
                    dt.Columns.Add("Configuration", typeof(string));
                    dt.Columns.Add("Electronegativity", typeof(double));
                    dt.Columns.Add("Oxidation", typeof(string));
                    foreach (var item in query)
                    {
                        DataRow row = dt.NewRow();
                        row["Number"] = item.Number;
                        row["Symbol"] = item.Symbol;
                        row["Name"] = item.Name;
                        row["AtomicMass"] = item.AtomicMass;
                        row["Configuration"] = item.Configuration;
                        row["Electronegativity"] = item.Electronegativity;
                        row["Oxidation"] = item.Oxidation;
                        dt.Rows.Add(row);
                    }
                    return dt;
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return new DataTable();
        }
        
        public DataTable getChemicalElementByNameAndSymbol(string symbol)
        {
            using (var db = new ScienceSolverModels())
            {
                var query = from q in db.ChemicalElement_View
                            where q.Name.Contains(symbol)||q.Symbol.Contains(symbol)
                            select q;
                DataTable dt = new DataTable();
                dt.Columns.Add("Number", typeof(int));
                dt.Columns.Add("Symbol", typeof(string));
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("AtomicMass", typeof(double));
                dt.Columns.Add("Configuration", typeof(string));
                dt.Columns.Add("Electronegativity", typeof(double));
                dt.Columns.Add("Oxidation", typeof(string));
                foreach (var item in query)
                {
                    DataRow row = dt.NewRow();
                    row["Number"] = item.Number;
                    row["Symbol"] = item.Symbol;
                    row["Name"] = item.Name;
                    row["AtomicMass"] = item.AtomicMass;
                    row["Configuration"] = item.Configuration;
                    row["Electronegativity"] = item.Electronegativity;
                    row["Oxidation"] = item.Oxidation;
                    dt.Rows.Add(row);
                }
                return dt;
            };
        }
    }
}
