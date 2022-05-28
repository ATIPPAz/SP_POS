using SP_POS.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SP_POS.Classes
{
    public class ConvertToDataTable
    {
        /* DataTable dataTable;
         public void header<T>(List<T> items)
         {
             dataTable = new DataTable(typeof(T).Name);
             PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
             foreach (PropertyInfo prop in Props)
             {
                 dataTable.Columns.Add(prop.Name);
             }
         }*/
        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
        /*  public void ToDataTable(List<Product> items,DataTable dt)
          {
              PropertyInfo[] Props = typeof(Product).GetProperties(BindingFlags.Public | BindingFlags.Instance);
              foreach (PropertyInfo prop in Props)
              {
                  dt.Columns.Add(prop.Name);
              }
              foreach (Product item in items)
              {
                  var values = new object[Props.Length];
                  for (int i = 0; i < Props.Length; i++)
                  {
                      values[i] = Props[i].GetValue(item, null);
                  }
                  dt.Rows.Add(values);
              }

          }*/

    }
}
