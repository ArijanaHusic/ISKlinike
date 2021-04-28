
namespace ISKlinike
{
    partial class KartonPacijenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDatumOtvaranja = new System.Windows.Forms.TextBox();
            this.txtBrojKartona = new System.Windows.Forms.TextBox();
            this.lblDatumOtv = new System.Windows.Forms.Label();
            this.lblBrojKartona = new System.Windows.Forms.Label();
            this.btnMinimiye = new System.Windows.Forms.Button();
            this.lblImePrezimePacijenta = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnLičniPodaci = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOboljenja = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNalazi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPeriodicniPregledi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIzdataUvjerenja = new System.Windows.Forms.ToolStripMenuItem();
            this.preventivneMjereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drugeUstanoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ispisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.txtDatumOtvaranja);
            this.panel1.Controls.Add(this.txtBrojKartona);
            this.panel1.Controls.Add(this.lblDatumOtv);
            this.panel1.Controls.Add(this.lblBrojKartona);
            this.panel1.Controls.Add(this.btnMinimiye);
            this.panel1.Controls.Add(this.lblImePrezimePacijenta);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1485, 91);
            this.panel1.TabIndex = 2;
            // 
            // txtDatumOtvaranja
            // 
            this.txtDatumOtvaranja.Location = new System.Drawing.Point(177, 49);
            this.txtDatumOtvaranja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDatumOtvaranja.Name = "txtDatumOtvaranja";
            this.txtDatumOtvaranja.Size = new System.Drawing.Size(148, 26);
            this.txtDatumOtvaranja.TabIndex = 11;
            // 
            // txtBrojKartona
            // 
            this.txtBrojKartona.Location = new System.Drawing.Point(177, 14);
            this.txtBrojKartona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBrojKartona.Name = "txtBrojKartona";
            this.txtBrojKartona.Size = new System.Drawing.Size(148, 26);
            this.txtBrojKartona.TabIndex = 10;
            // 
            // lblDatumOtv
            // 
            this.lblDatumOtv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumOtv.ForeColor = System.Drawing.Color.White;
            this.lblDatumOtv.Location = new System.Drawing.Point(4, 49);
            this.lblDatumOtv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatumOtv.Name = "lblDatumOtv";
            this.lblDatumOtv.Size = new System.Drawing.Size(188, 35);
            this.lblDatumOtv.TabIndex = 9;
            this.lblDatumOtv.Text = "Datum otvaranja:";
            // 
            // lblBrojKartona
            // 
            this.lblBrojKartona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojKartona.ForeColor = System.Drawing.Color.White;
            this.lblBrojKartona.Location = new System.Drawing.Point(4, 14);
            this.lblBrojKartona.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrojKartona.Name = "lblBrojKartona";
            this.lblBrojKartona.Size = new System.Drawing.Size(150, 35);
            this.lblBrojKartona.TabIndex = 7;
            this.lblBrojKartona.Text = "Broj kartona:";
            // 
            // btnMinimiye
            // 
            this.btnMinimiye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimiye.ForeColor = System.Drawing.Color.Red;
            this.btnMinimiye.Location = new System.Drawing.Point(1392, 34);
            this.btnMinimiye.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinimiye.Name = "btnMinimiye";
            this.btnMinimiye.Size = new System.Drawing.Size(52, 46);
            this.btnMinimiye.TabIndex = 6;
            this.btnMinimiye.Text = "_";
            this.btnMinimiye.UseVisualStyleBackColor = true;
            // 
            // lblImePrezimePacijenta
            // 
            this.lblImePrezimePacijenta.AutoSize = true;
            this.lblImePrezimePacijenta.Font = new System.Drawing.Font("Lucida Handwriting", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePrezimePacijenta.ForeColor = System.Drawing.Color.White;
            this.lblImePrezimePacijenta.Location = new System.Drawing.Point(531, 31);
            this.lblImePrezimePacijenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImePrezimePacijenta.Name = "lblImePrezimePacijenta";
            this.lblImePrezimePacijenta.Size = new System.Drawing.Size(220, 40);
            this.lblImePrezimePacijenta.TabIndex = 0;
            this.lblImePrezimePacijenta.Text = "ImePrezime";
            this.lblImePrezimePacijenta.UseMnemonic = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1341, 34);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 46);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLičniPodaci,
            this.btnOboljenja,
            this.btnNalazi,
            this.btnPeriodicniPregledi,
            this.btnIzdataUvjerenja,
            this.preventivneMjereToolStripMenuItem,
            this.drugeUstanoveToolStripMenuItem,
            this.ispisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 92);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 9, 9, 15);
            this.menuStrip1.Size = new System.Drawing.Size(1456, 94);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnLičniPodaci
            // 
            this.btnLičniPodaci.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLičniPodaci.Name = "btnLičniPodaci";
            this.btnLičniPodaci.Size = new System.Drawing.Size(157, 70);
            this.btnLičniPodaci.Text = "Lični podaci";
            this.btnLičniPodaci.Click += new System.EventHandler(this.btnLičniPodaci_Click_1);
            // 
            // btnOboljenja
            // 
            this.btnOboljenja.Name = "btnOboljenja";
            this.btnOboljenja.Size = new System.Drawing.Size(134, 70);
            this.btnOboljenja.Text = "Oboljenja";
            this.btnOboljenja.Click += new System.EventHandler(this.oboljenjaToolStripMenuItem_Click);
            // 
            // btnNalazi
            // 
            this.btnNalazi.Name = "btnNalazi";
            this.btnNalazi.Size = new System.Drawing.Size(96, 70);
            this.btnNalazi.Text = "Nalazi";
            this.btnNalazi.Click += new System.EventHandler(this.nalaziToolStripMenuItem_Click);
            // 
            // btnPeriodicniPregledi
            // 
            this.btnPeriodicniPregledi.Name = "btnPeriodicniPregledi";
            this.btnPeriodicniPregledi.Size = new System.Drawing.Size(230, 70);
            this.btnPeriodicniPregledi.Text = "Periodični pregledi";
            this.btnPeriodicniPregledi.Click += new System.EventHandler(this.periodičniPreglediToolStripMenuItem_Click);
            // 
            // btnIzdataUvjerenja
            // 
            this.btnIzdataUvjerenja.Name = "btnIzdataUvjerenja";
            this.btnIzdataUvjerenja.Size = new System.Drawing.Size(199, 70);
            this.btnIzdataUvjerenja.Text = "Izdata uvjerenja";
            this.btnIzdataUvjerenja.Click += new System.EventHandler(this.btnIzdataUvjerenja_Click);
            // 
            // preventivneMjereToolStripMenuItem
            // 
            this.preventivneMjereToolStripMenuItem.Name = "preventivneMjereToolStripMenuItem";
            this.preventivneMjereToolStripMenuItem.Size = new System.Drawing.Size(225, 70);
            this.preventivneMjereToolStripMenuItem.Text = "Preventivne mjere";
            this.preventivneMjereToolStripMenuItem.Click += new System.EventHandler(this.preventivneMjereToolStripMenuItem_Click);
            // 
            // drugeUstanoveToolStripMenuItem
            // 
            this.drugeUstanoveToolStripMenuItem.Name = "drugeUstanoveToolStripMenuItem";
            this.drugeUstanoveToolStripMenuItem.Size = new System.Drawing.Size(201, 70);
            this.drugeUstanoveToolStripMenuItem.Text = "Druge ustanove";
            this.drugeUstanoveToolStripMenuItem.Click += new System.EventHandler(this.drugeUstanoveToolStripMenuItem_Click);
            // 
            // ispisToolStripMenuItem
            // 
            this.ispisToolStripMenuItem.Name = "ispisToolStripMenuItem";
            this.ispisToolStripMenuItem.Size = new System.Drawing.Size(193, 70);
            this.ispisToolStripMenuItem.Text = "Datumi posjeta";
            this.ispisToolStripMenuItem.Click += new System.EventHandler(this.ispisToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(168, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 57);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(300, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 57);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(399, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 57);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(624, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 57);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(820, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 57);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1042, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2, 57);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1240, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 57);
            this.label7.TabIndex = 12;
            this.label7.Text = "label7";
            // 
            // KartonPacijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISKlinike.Properties.Resources.pngtree_vector_white_background_with_abstract_geometric_pattern_or_textu_image_265390;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1454, 1106);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KartonPacijenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KartonPacijenta";
            this.Load += new System.EventHandler(this.KartonPacijenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimiye;
        private System.Windows.Forms.Label lblImePrezimePacijenta;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtDatumOtvaranja;
        private System.Windows.Forms.TextBox txtBrojKartona;
        private System.Windows.Forms.Label lblDatumOtv;
        private System.Windows.Forms.Label lblBrojKartona;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnLičniPodaci;
        private System.Windows.Forms.ToolStripMenuItem btnOboljenja;
        private System.Windows.Forms.ToolStripMenuItem btnNalazi;
        private System.Windows.Forms.ToolStripMenuItem btnPeriodicniPregledi;
        private System.Windows.Forms.ToolStripMenuItem btnIzdataUvjerenja;
        private System.Windows.Forms.ToolStripMenuItem preventivneMjereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drugeUstanoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ispisToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}