using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PresentationLayer
{
    public class utilites_presentation
    {
        public static void mensaje_ok(string mensaje)
        {
            MessageBox.Show(mensaje, "JPSOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void mensaje_error(string mensaje)
        {
            MessageBox.Show(mensaje, "JPSOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool isdataset_empty(DataSet ds)
        {
            if (ds.Tables[0].Rows.Count == 0)
                return true;
            return false;
        }

    }
}
