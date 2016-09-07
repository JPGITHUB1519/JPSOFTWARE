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

        // return True if empty
        public static bool validar(Control frm, ErrorProvider errorp)
        {
            bool cond = false;
            foreach (Control obj in frm.Controls)
            {
                if (obj.Controls.Count > 0)
                {
                    cond = validar(obj, errorp);
                }
                else
                {
                    if (obj is jptextbox)
                    {
                        jptextbox obj2 = (jptextbox)obj;

                        if (obj2.validar)
                        {

                            if (String.IsNullOrEmpty(obj2.Text.Trim()))
                            {
                                errorp.SetError(obj, "Campo obligatorio");
                                cond = true;
                            }
                            else
                            {
                                errorp.SetError(obj, "");
                            }

                        }
                    }

                }
            }
            return cond;
        }

        public bool isint(string num)
        {
            try
            {
                Int32.Parse(num);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
