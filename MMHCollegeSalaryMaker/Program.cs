using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MMHCollegeSalaryMaker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frm_mmh_clg_salary_maker());
            Application.Run(new Form_mmh_slry_login_screen());
        }
    }
}
