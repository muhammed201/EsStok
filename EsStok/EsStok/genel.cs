using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EsStok
{
    internal class genel
    {
        public static bool acikFormKontrolEt(string name)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                //MessageBox.Show(frm.Name.ToString());                
                if (frm.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
