using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeworkLibrary;
using HomeworkLibrary.Forms;
using HomeworkLibrary.hSystem;
using HomeworkLibrary.Users;

namespace HomeworkGUI
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
            Form chosenForm = null;
            switch (HomeworkLibrary.Main.GetCurrentForm())
            {
                case AppForms.UserInfo:
                    chosenForm = new UserInfoForm();
                    break;
                case AppForms.Courses:
                    chosenForm = new CourseForm();
                    User.AppUser = User.GetUser();
                    break;
                case AppForms.Main:
                    User.AppUser = User.GetUser();
                    chosenForm = new MainForm();
                    break;
            }
            try
            {
                Application.Run(chosenForm);
            }
            catch (Exception e)
            {
                ErrorLogging.Write(e);
                MessageBox.Show("An error prevented the app from running. Sorry");
            }
        }
    }
}
