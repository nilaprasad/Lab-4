using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PRG655_Lab4_P1_
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        //Public Properties
        public string filepath;
        public string username;

        //Appropriate property declarations
        public string FilePath
        {
            get
            {
                return filepath;
            }
            set
            {
                filepath = value;
            }
        }

        public string AccessCode
        {
            get
            {
                return txtPinInput.Text;
            }
        }

        public string UserName
        {
            get
            {
                return username;
            }
        }

        //Events for when Get Access is clicked
        public event EventHandler AccessOK;
        public event EventHandler AccessNO;

        //Event declarations 
        protected virtual void OnAccessOK(EventArgs e)
        {
            EventHandler handler = AccessOK;
            if (handler != null)
            {
                try
                {
                    using (StreamReader sr = new StreamReader("Logins.txt"))
                    {
                        String line = sr.ReadToEnd();
                        if (line.Contains(AccessCode))
                            MessageBox.Show("Access Granted.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error has occured.");
                }
            }
        }

        protected virtual void OnAccessNO(EventArgs e)
        {
            EventHandler handler = AccessNO;
            if (handler != null)
            {
                try
                {
                    using (StreamReader sr = new StreamReader("Logins.txt"))
                    {
                        String line = sr.ReadToEnd();
                        if (!line.Contains(AccessCode))
                            MessageBox.Show("You do not have proper access. Contact your manager for assitance.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error has occured.");
                }
            }
        }
    }
}
