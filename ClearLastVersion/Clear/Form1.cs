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
    public partial class Form1 : Form
    {
        /// <summary>
        /// field flag Internet
        /// </summary>
        private bool flagInternet = false;
        /// <summary>
        /// field flag File
        /// </summary>
        private bool flagFile = false;
        /// <summary>
        /// field flag delete
        /// </summary>
        private bool flagDelete = false;
        /// <summary>
        /// field flag process
        /// </summary>
        private bool flagProcess = false;
        /// <summary>
        /// field flag clear
        /// </summary>
        private bool flagClear = false;
        /// <summary>
        /// field dictionary for patern Strategy
        /// </summary>
        private Dictionary<string, Delete> information = new Dictionary<string, Delete>();
        /// <summary>
        /// field internet
        /// </summary>
        private Internet internet = new Internet();
        /// <summary>
        /// field system files
        /// </summary>
        private SystemFile system = new SystemFile();

        /// <summary>
        /// default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.btnInternet_Click(this, null);
            this.CharacterPC();
            this.btnAnalize.BackColor = Color.Blue;
            this.btnClear.BackColor = Color.Blue;
            this.FillDicInte();
            this.FillDicSystemFile();
            this.Button();
            Mediator.MainMathod += this.Question;
            Mediator.SetAnswer = (x) => this.flagProcess = x;
        }

        /// <summary>
        /// methof for remove frames for all button
        /// </summary>
        private void Button()
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;
            }
        }

        /// <summary>
        /// method for filleng dictionary Internet
        /// </summary>
        private void FillDicInte()
        {
            this.information.Add("Chrome", this.internet.GetChrome);
            this.information.Add("Opera", this.internet.GetOpera);
            this.information.Add("Mozilla", this.internet.GetMozilla);
            this.information.Add("Explorer", this.internet.GetExplorer);
        }

        /// <summary>
        /// method for filling dictionary SystemFile
        /// </summary>
        private void FillDicSystemFile()
        {
            this.information.Add("Recently documents", this.system.GetRecentDocuments);
            this.information.Add("Temporary files", this.system.GetTemp);
            this.information.Add("Memory Dump", this.system.GetMemoryDumps);
            this.information.Add("Log Files", this.system.GetLogFiles);
            this.information.Add("Error Reporting Windows", this.system.GetErrorReporting);
            this.information.Add("Prefetch files", this.system.GetPrefetchFiles);
            this.information.Add("Recycle files", this.system.GetRecycle);
        }

        /// <summary>
        /// method for call static class CharecterPC
        /// </summary>
        private void CharacterPC()
        {
            this.LBWindows.Text = CharecterPC.Windows();
            this.LBProcess.Text = CharecterPC.Proccesor();
            this.LBVideoController.Text = CharecterPC.VideoController();
            this.LBRam.Text = CharecterPC.RAM();
        }


        /// <summary>
        /// method for btnInternet mause move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInternet_MouseMove(object sender, MouseEventArgs e)
        {
            if (!flagInternet)
                this.btnInternet.BackColor = SystemColors.ControlDarkDark;
        }

        /// <summary>
        /// methof for btnInternet MouseLeave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInternet_MouseLeave(object sender, EventArgs e)
        {
            if (!flagInternet)
                this.btnInternet.BackColor = SystemColors.ButtonShadow;
        }

        /// <summary>
        /// method for btnInternet Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInternet_Click(object sender, EventArgs e)
        {
            this.flagFile = false;
            this.bynFile_MouseLeave(this, e);
            this.btnInternet.BackColor = Color.Blue;
            this.flagInternet = true;
            this.FillInternet();
        }

        /// <summary>
        /// method for fill checkBox Internet
        /// </summary>
        private void FillInternet()
        {
            this.cLBOperation.Items.Clear();
            this.cLBOperation.Items.Add("Internet Caché");
            this.cLBOperation.Items.Add("Internet History");
            this.cLBOperation.Items.Add("Cookie");
        }

        /// <summary>
        /// method for btnFile Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bynFile_Click(object sender, EventArgs e)
        {
            this.flagInternet = false;
            this.btnInternet_MouseLeave(this, e);
            this.btnFile.BackColor = Color.Blue;
            this.flagFile = true;
            this.cLBOperation.Items.Clear();
            this.cLBOperation.Items.Add("Recently Documents");
            this.cLBOperation.Items.Add("Temporary Files");
            this.cLBOperation.Items.Add("Memory Dumps");
            this.cLBOperation.Items.Add("Log Files");
            this.cLBOperation.Items.Add("Error Reporting");
            this.cLBOperation.Items.Add("Prefetch files");
            this.cLBOperation.Items.Add("Recycle files");
        }

        /// <summary>
        /// method bynFile MouseLeave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bynFile_MouseLeave(object sender, EventArgs e)
        {
            if (!flagFile)
                this.btnFile.BackColor = SystemColors.ButtonShadow;
        }

        /// <summary>
        /// method bynFile MouseMove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bynFile_MouseMove(object sender, MouseEventArgs e)
        {
            if (!flagFile)
                this.btnFile.BackColor = SystemColors.ControlDarkDark;
        }

        /// <summary>
        /// methof for btnAnalize Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnalize_Click(object sender, EventArgs e)
        {
            this.btnBack_Click(this, e);
            this.information.Clear();
            if (this.flagInternet)
                this.FillDicInte();
            else
                this.FillDicSystemFile();
            this.flagClear = false;
            this.internet.Reset();
            Mediator.Answer = 0;
            this.system.Reset();
            this.LVInformation.Items.Clear();
            this.Information();
        }

        /// <summary>
        /// method for cheking info choise user
        /// </summary>
        public void Information()
        {
            if (!this.flagClear)
            {
                this.progressBar1.Value = 0;
                bool flag = false;
                if (flagInternet)
                {
                    this.progressBar1.Step = 100 / 3;
                    int count = 1;
                    foreach (int index in this.cLBOperation.CheckedIndices)
                    {

                        if (index == 0)
                        {
                            this.internet.Cache(this.flagDelete);
                        }
                        else if (index == 1)
                        {
                            this.internet.History(this.flagDelete);
                        }
                        else
                        {
                            this.internet.Cookies(this.flagDelete);
                        }
                        flag = true;
                        this.progressBar1.PerformStep();
                        count++;
                    }
                    this.FeelLvInformation(this.internet.GetList());
                }
                else
                {
                    this.progressBar1.Step = 100 / 5;
                    foreach (int check in this.cLBOperation.CheckedIndices)
                    {
                        if (check == 0)
                        {
                            this.system.CallClearRecentDoc(this.flagDelete);
                        }
                        else if (check == 1)
                        {
                            this.system.CallClearTempFiles(this.flagDelete);
                        }
                        else if (check == 2)
                        {
                            this.system.CallClearMemodyDumps(this.flagDelete);
                        }
                        else if (check == 3)
                        {
                            this.system.CallClearLogFiles(this.flagDelete);
                        }
                        else if (check == 4)
                        {
                            this.system.CallClearErrorReporting(this.flagDelete);
                        }
                        else if (check == 5)
                        {
                            this.system.CallClearPrefetchFiles(this.flagDelete);
                        }
                        else if (check == 6)
                        {
                            this.system.CallClearRecycle(this.flagDelete);
                        }
                        flag = true;
                        this.progressBar1.PerformStep();
                    }
                    this.FeelLvInformation(this.system.GetInfo());
                }
                if (flag) this.progressBar1.Value = 100;
            }
        }

        /// <summary>
        /// methof for fill LVInformation
        /// </summary>
        /// <param name="info"></param>
        private void FeelLvInformation(List<string> info)
        {
            foreach (var buf in info)
            {
                this.LVInformation.Items.Add(new ListViewItem(buf.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries), this.ImadeIndex(buf)));
            }
        }

        /// <summary>
        /// method for seacrh index image
        /// </summary>
        /// <param name="buf"></param>
        /// <returns></returns>
        private int ImadeIndex(string buf)
        {
            if (buf.Contains("Chrome"))
                return 0;
            else if (buf.Contains("Mozilla"))
                return 1;
            else if (buf.Contains("Explorer"))
                return 2;
            else if (buf.Contains("Opera"))
                return 3;
            return 4;
        }

        /// <summary>
        /// method for btnClear Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.btnBack_Click(this, e);
            if (this.LVInformation.Items.Count != 0)
            {
                this.flagDelete = true;
                Information();
                this.LVInformation.Items.Clear();
                this.LVInformation.Items.Add("File Delete");
                this.flagDelete = false;
            };
            if (this.LVInformation.Items.Count > 0)
                this.flagClear = true;
        }

        /// <summary>
        /// method for call form Ask
        /// </summary>
        /// <param name="browser"></param>
        /// <returns></returns>
        private bool Question(string browser)
        {
            if (Mediator.Answer == 0)
            {
                Ask ask = new Ask();
                Mediator.GetBroewser(browser);
                ask.ShowDialog();
            }
            return this.flagProcess;
        }

        /// <summary>
        /// method for open info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.LVInformation.SelectedItems)
            {
                foreach (var key in this.information.Keys)
                {
                    this.LVInfoFiles.Visible = true;
                    this.progressBar1.Visible = false;
                    this.btnBack.Visible = true;
                    if (item.ToString().Contains(key))
                    {
                        try
                        {
                            if (!this.information[key].GetAcess())
                            {
                                this.LVInfoFiles.Items.Add("Skip Analysis", this.ImadeIndex(key));
                                break;
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                        if (item.ToString().Contains("cache"))
                        {
                            this.FellLVInfoFile(this.information[key].GetWayCache, this.ImadeIndex(key));
                        }
                        else if (item.ToString().Contains("cookies"))
                        {
                            this.FellLVInfoFile(this.information[key].GetWayCookies, this.ImadeIndex(key));
                        }
                        else if (item.ToString().Contains("history"))
                        {
                            this.FellLVInfoFile(this.information[key].GetWayHistory, this.ImadeIndex(key));
                        }
                        else
                        {
                            this.FellLVInfoFile(this.information[key].GetSysytemFile, this.ImadeIndex(key));
                        }
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// method for filling LVInfoFiles
        /// </summary>
        /// <param name="files"></param>
        /// <param name="ImageIndex"></param>
        private void FellLVInfoFile(List<string> files, int ImageIndex)
        {
            foreach (var file in files)
            {
                this.LVInfoFiles.Items.Add(file, ImageIndex);
            }

        }

        /// <summary>
        /// method for btnBack Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.LVInfoFiles.Items.Clear();
            this.LVInfoFiles.Visible = false;
            this.btnBack.Visible = false;
            this.progressBar1.Visible = true;
        }

        /// <summary>
        /// method for LVInformation MouseDoubleClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LVInformation_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.viewToolStripMenuItem_Click(this, e);
        }

        /// <summary>
        /// method for backToolStripMenuItem Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnBack_Click(this, e);
        }

        /// <summary>
        /// methof for open explorer process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem file in this.LVInfoFiles.SelectedItems)
            {
                OpenProcess.CreateProcessOpen(file.Text);
            }
        }

        /// <summary>
        /// method for open  form About
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }
        
        /// <summary>
        /// method btnAbout_MouseLeave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            this.btnAbout.BackColor = SystemColors.ButtonShadow;
        }

        /// <summary>
        /// method btnAbout_MouseMove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnAbout.BackColor = SystemColors.ControlDarkDark;
        }

        /// <summary>
        /// method for change size listView first colums
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_SizeChanged(object sender, EventArgs e)
        {

            this.LVInformation.Columns[0].Width = this.Size.Width - 500;
            this.LVInfoFiles.Columns[0].Width = this.LVInfoFiles.Size.Width;
        }




    }
}
