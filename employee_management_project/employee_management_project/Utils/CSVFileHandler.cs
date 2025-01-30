using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_management_project.Utils
{
    public static class CSVFileHandler
    {
        public static void ReadCSVFile(string filePath, ref SortableBindingList<Employee> result)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length < 2)
                {
                    return;
                }

                string[] headers = lines[0].Split(','); // Read header row

                

                foreach (string line in lines.Skip(1)) // Skip header
                {
                    Employee employee = new Employee();

                    string[] values = line.Split(',');

                    PropertyInfo[] properties = typeof(Employee).GetProperties();

                    for (int i = 0; i < headers.Length; i++)
                    {
                        PropertyInfo property = findProperty(properties, headers[i]);

                        if (property != null)
                        {
                            object convertedValue = Convert.ChangeType(values[i], property.PropertyType);
                            property.SetValue(employee, convertedValue);
                        }
                    }

                    result.Add(employee);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private static PropertyInfo findProperty(in PropertyInfo[] properties, string propertyName) {
            PropertyInfo property = null;
            foreach (PropertyInfo p in properties)
            {
                if (p.Name.Equals(propertyName, StringComparison.OrdinalIgnoreCase))
                {
                    property = p;
                    break;
                }
            }

            return property;
        }

        public static void WriteCSVFile(string filePath, in SortableBindingList<Employee> result)
        {
            if (result == null) return;

            var properties = typeof(Employee).GetProperties();
            var sb = new StringBuilder();

            // Write header
            List<string> headers = new List<string>();
            foreach (var p in properties)
            {
                string value = p.Name;
                headers.Add(value);
            }
            sb.AppendLine(string.Join(",", headers));


            // Write data rows
            foreach (var item in result)
            {
                List<string> values = new List<string>();

                foreach (var p in properties)
                {
                    object value = p.GetValue(item, null);
                    string strValue = value == null ? "" : value.ToString();
                    values.Add(strValue);
                }
                sb.AppendLine(string.Join(",", values));
            }

            try
            {
                File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
    }
}
