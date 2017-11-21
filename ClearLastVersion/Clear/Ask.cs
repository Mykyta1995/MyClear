using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clear
{
    /// <summary>
    /// class form2 for asked user close browser 
    /// </summary>
    public partial class Ask : Form
    {

        /// <summary>
        /// default constructor
        /// </summary>
        public Ask()
        {
            InitializeComponent();
            this.btnNo.BackColor = Color.Blue;
            this.btnYes.BackColor = Color.Blue;
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;
            }
            Mediator.GetBroewser = (x) =>
                {
                    if (x.Contains("firefox"))
                    {
                        this.label1.Text = string.Format("Mozilla Firefox {0}", this.label1.Text);
                        this.label2.Text = string.Format("{0} Mozilla Firefox?", this.label2.Text);
                    }
                    else if (x.Contains("chrome"))
                    {
                        this.label1.Text = string.Format("Google Chrome {0}", this.label1.Text);
                        this.label2.Text = string.Format("{0} Google Chrome?", this.label2.Text);
                    }
                    else if (x.Contains("iexplore"))
                    {
                        this.label1.Text = string.Format("Internet Explorer {0}", this.label1.Text);
                        this.label2.Text = string.Format("{0} Internet Explorer?", this.label2.Text);
                    }
                    else if (x.Contains("opera"))
                    {
                        this.label1.Text = string.Format("Opera {0}", this.label1.Text);
                        this.label2.Text = string.Format("{0} Opera?", this.label2.Text);
                    }
                };

        }


        /// <summary>
        /// method for understand checked checkBox and choise "Yes"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYes_Click(object sender, EventArgs e)
        {
            if(this.checkBox1.Checked)
                            Mediator.Answer=1;
            Mediator.SetAnswer(true);
            this.Close();
        }

        /// <summary>
        /// method for understand checked chekBox and chosie "No"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_Click(object sender, EventArgs e)
        {
            if(this.checkBox1.Checked)
                            Mediator.Answer=2;
            Mediator.SetAnswer(false);
            this.Close();
        }
    }
}
