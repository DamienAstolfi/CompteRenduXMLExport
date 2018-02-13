using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompteRenduXMLExport
{
    public partial class FrmCompterenduVisualisation : Form
    {
        private List<V_Compte_Rendu> crList { get; set; }
        private System.IO.MemoryStream ms { get; set; }

        public FrmCompterenduVisualisation()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            using (TibcoGPEntities model = new TibcoGPEntities())
            {
                crList = new List<V_Compte_Rendu>();
                crList.AddRange(from c in model.V_Compte_Rendu orderby c.cr_id select c);

                lblCnx.Text = model.Database.Connection.ConnectionString;
            }

            this.cmbCR.DisplayMember = "cr_id";
            this.cmbCR.DataSource = crList;

            splitContainerSearch.SplitterDistance = this.Width;
        }

        private void cmbCR_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (TibcoGPEntities model = new TibcoGPEntities())
            {
                model.Database.CommandTimeout = 200;

                var xml = model.Compte_rendu.Where(x => x.cr_id == ((V_Compte_Rendu)cmbCR.SelectedValue).cr_id).Select(x => x.cr_rapport).FirstOrDefault();
                if (!string.IsNullOrEmpty(xml))
                {
                    System.Xml.Linq.XDocument xDocument = System.Xml.Linq.XDocument.Parse(xml);
                    txtXML.Text = xDocument.ToString();

                    System.Xml.Linq.XDocument xXslt = System.Xml.Linq.XDocument.Parse(Properties.Resources.Defaultss);

                    System.Xml.Xsl.XslCompiledTransform xTrans = new System.Xml.Xsl.XslCompiledTransform();
                    xTrans.Load(xXslt.CreateReader());
                    ms = new System.IO.MemoryStream();
                    xTrans.Transform(xDocument.CreateReader(), null, ms);
                    ms.Position = 0;
                    webBrowserXML.DocumentStream = ms;
                }
                else
                {
                    txtXML.Clear();
                    txtXML.Text = "VIDE";
                    webBrowserXML.DocumentText = string.Empty;
                }
            }
        }

        private void btnSauvegarde_Click(object sender, EventArgs e)
        {
            try
            {
                using (TibcoGPEntities model = new TibcoGPEntities())
                {
                    if (MessageBox.Show(string.Format("êtes vous sur de vouloir modifier {0} ?", model.Database.Connection.DataSource), "Sauvegarde en BDD ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        var cr = model.Compte_rendu.Where(x => x.cr_id == ((V_Compte_Rendu)cmbCR.SelectedValue).cr_id).Select(x => x).FirstOrDefault();
                        if (cr != null)
                            cr.cr_rapport = txtXML.Text;
                        model.SaveChanges();
                        MessageBox.Show("Sauvegarde réussi", "Sauvegarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de la sauvegarde:" + ex.Message, "Sauvegarde", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCompterenduVisualisation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                splitContainerSearch.SplitterDistance = this.Width - 200;
                panelSearch.Visible = true;
                txtSearch.Focus();
                this.AcceptButton = btnSearch;
                this.CancelButton = btnCancel;
            }
        }

        int index { get; set; }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                if (txtXML.Text.IndexOf(txtSearch.Text, index) != -1)
                {
                    index = txtXML.Text.IndexOf(txtSearch.Text, index) + txtSearch.Text.Length;
                    txtXML.Select(index - txtSearch.Text.Length, txtSearch.Text.Length);
                    txtXML.SelectionColor = Color.Yellow;
                    txtXML.SelectionBackColor = Color.Blue;
                    try
                    {
                        txtXML.ScrollToCaret(); // try/caught because this has been known to fail unexpectedly
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            index = 0;
            splitContainerSearch.SplitterDistance = this.Width;
            panelSearch.Visible = false;
            cmbCR.Focus();
            var TempString = txtXML.Text;
            txtXML.Rtf = string.Empty;
            txtXML.Text = TempString;
            this.AcceptButton = null;
            this.CancelButton = null;
        }

        private void FrmCompterenduVisualisation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.ms != null)
                ms.Dispose();

            if (this.crList != null)
            {
                crList.Clear();
                crList = null;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (!System.IO.Directory.Exists(@"c:\temp"))
                    System.IO.Directory.CreateDirectory(@"c:\temp");

                string path = string.Format(@"c:\temp\{0}.xml", ((V_Compte_Rendu)cmbCR.SelectedValue).cr_id);

                System.IO.File.WriteAllText(path, txtXML.Text);
                //string cmd = string.Format(@"""C:\Program Files\Notepad++\notepad++.exe"" -lxml {0}", path).Replace(@"\\", @"\");
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                process.StartInfo.FileName = @"C:\Program Files\Notepad++\notepad++.exe";
                process.StartInfo.Arguments = string.Format(@"-lxml {0}", path).Replace(@"\\", @"\");
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur d'ouverture: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
