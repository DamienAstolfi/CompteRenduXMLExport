namespace CompteRenduXMLExport
{
    partial class FrmCompterenduVisualisation
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompterenduVisualisation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSauvegarde = new System.Windows.Forms.Button();
            this.cmbCR = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainerSearch = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtXML = new System.Windows.Forms.RichTextBox();
            this.lblCnx = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControlRenderCR = new System.Windows.Forms.TabControl();
            this.tabPageText = new System.Windows.Forms.TabPage();
            this.tabPageXML = new System.Windows.Forms.TabPage();
            this.webBrowserXML = new System.Windows.Forms.WebBrowser();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSearch)).BeginInit();
            this.splitContainerSearch.Panel1.SuspendLayout();
            this.splitContainerSearch.Panel2.SuspendLayout();
            this.splitContainerSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.tabControlRenderCR.SuspendLayout();
            this.tabPageText.SuspendLayout();
            this.tabPageXML.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.btnSauvegarde);
            this.panel1.Controls.Add(this.cmbCR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnSauvegarde
            // 
            this.btnSauvegarde.Location = new System.Drawing.Point(435, 12);
            this.btnSauvegarde.Name = "btnSauvegarde";
            this.btnSauvegarde.Size = new System.Drawing.Size(121, 23);
            this.btnSauvegarde.TabIndex = 1;
            this.btnSauvegarde.Text = "Sauvegarder";
            this.btnSauvegarde.UseVisualStyleBackColor = true;
            this.btnSauvegarde.Click += new System.EventHandler(this.btnSauvegarde_Click);
            // 
            // cmbCR
            // 
            this.cmbCR.FormattingEnabled = true;
            this.cmbCR.Location = new System.Drawing.Point(13, 13);
            this.cmbCR.Name = "cmbCR";
            this.cmbCR.Size = new System.Drawing.Size(259, 21);
            this.cmbCR.TabIndex = 0;
            this.cmbCR.SelectedIndexChanged += new System.EventHandler(this.cmbCR_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainerSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 261);
            this.panel2.TabIndex = 1;
            // 
            // splitContainerSearch
            // 
            this.splitContainerSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSearch.Location = new System.Drawing.Point(0, 0);
            this.splitContainerSearch.Name = "splitContainerSearch";
            // 
            // splitContainerSearch.Panel1
            // 
            this.splitContainerSearch.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainerSearch.Panel2
            // 
            this.splitContainerSearch.Panel2.Controls.Add(this.panelSearch);
            this.splitContainerSearch.Size = new System.Drawing.Size(746, 261);
            this.splitContainerSearch.SplitterDistance = 566;
            this.splitContainerSearch.TabIndex = 2;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer3.Size = new System.Drawing.Size(566, 261);
            this.splitContainer3.SplitterDistance = 40;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControlRenderCR);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblCnx);
            this.splitContainer1.Size = new System.Drawing.Size(566, 217);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtXML
            // 
            this.txtXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXML.Location = new System.Drawing.Point(3, 3);
            this.txtXML.Name = "txtXML";
            this.txtXML.Size = new System.Drawing.Size(552, 153);
            this.txtXML.TabIndex = 0;
            this.txtXML.Text = "";
            // 
            // lblCnx
            // 
            this.lblCnx.AutoSize = true;
            this.lblCnx.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCnx.Location = new System.Drawing.Point(501, 6);
            this.lblCnx.Name = "lblCnx";
            this.lblCnx.Size = new System.Drawing.Size(64, 13);
            this.lblCnx.TabIndex = 0;
            this.lblCnx.Text = "Connection:";
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.btnCancel);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(176, 261);
            this.panelSearch.TabIndex = 4;
            this.panelSearch.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(97, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(176, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(2, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControlRenderCR
            // 
            this.tabControlRenderCR.Controls.Add(this.tabPageText);
            this.tabControlRenderCR.Controls.Add(this.tabPageXML);
            this.tabControlRenderCR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRenderCR.Location = new System.Drawing.Point(0, 0);
            this.tabControlRenderCR.Name = "tabControlRenderCR";
            this.tabControlRenderCR.SelectedIndex = 0;
            this.tabControlRenderCR.Size = new System.Drawing.Size(566, 185);
            this.tabControlRenderCR.TabIndex = 0;
            // 
            // tabPageText
            // 
            this.tabPageText.Controls.Add(this.txtXML);
            this.tabPageText.Location = new System.Drawing.Point(4, 22);
            this.tabPageText.Name = "tabPageText";
            this.tabPageText.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageText.Size = new System.Drawing.Size(558, 159);
            this.tabPageText.TabIndex = 0;
            this.tabPageText.Text = "Text";
            this.tabPageText.UseVisualStyleBackColor = true;
            // 
            // tabPageXML
            // 
            this.tabPageXML.Controls.Add(this.webBrowserXML);
            this.tabPageXML.Location = new System.Drawing.Point(4, 22);
            this.tabPageXML.Name = "tabPageXML";
            this.tabPageXML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageXML.Size = new System.Drawing.Size(558, 159);
            this.tabPageXML.TabIndex = 1;
            this.tabPageXML.Text = "XML";
            this.tabPageXML.UseVisualStyleBackColor = true;
            // 
            // webBrowserXML
            // 
            this.webBrowserXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserXML.Location = new System.Drawing.Point(3, 3);
            this.webBrowserXML.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserXML.Name = "webBrowserXML";
            this.webBrowserXML.Size = new System.Drawing.Size(552, 153);
            this.webBrowserXML.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(287, 11);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(127, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Ouvrir dans notepad++";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // FrmCompterenduVisualisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 261);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmCompterenduVisualisation";
            this.Text = "Visalisateur de Compte Rendu XML";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCompterenduVisualisation_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCompterenduVisualisation_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainerSearch.Panel1.ResumeLayout(false);
            this.splitContainerSearch.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSearch)).EndInit();
            this.splitContainerSearch.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.tabControlRenderCR.ResumeLayout(false);
            this.tabPageText.ResumeLayout(false);
            this.tabPageXML.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtXML;
        private System.Windows.Forms.ComboBox cmbCR;
        private System.Windows.Forms.Button btnSauvegarde;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblCnx;
        private System.Windows.Forms.SplitContainer splitContainerSearch;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TabControl tabControlRenderCR;
        private System.Windows.Forms.TabPage tabPageText;
        private System.Windows.Forms.TabPage tabPageXML;
        private System.Windows.Forms.WebBrowser webBrowserXML;
        private System.Windows.Forms.Button btnOpen;
    }
}

