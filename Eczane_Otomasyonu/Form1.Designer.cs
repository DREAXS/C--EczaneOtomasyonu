namespace Eczane_Otomasyonu
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastalarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastayıGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçlarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güvenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güvenceEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.MaskedTextBox();
            this.txtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastalarToolStripMenuItem,
            this.ilaçlarToolStripMenuItem,
            this.güvenceToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastalarToolStripMenuItem
            // 
            this.hastalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKaydıToolStripMenuItem,
            this.hastalarıListeleToolStripMenuItem,
            this.hastaSilToolStripMenuItem,
            this.hastayıGüncelleToolStripMenuItem});
            this.hastalarToolStripMenuItem.Name = "hastalarToolStripMenuItem";
            this.hastalarToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.hastalarToolStripMenuItem.Text = "Hastalar";
            // 
            // hastaKaydıToolStripMenuItem
            // 
            this.hastaKaydıToolStripMenuItem.Name = "hastaKaydıToolStripMenuItem";
            this.hastaKaydıToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.hastaKaydıToolStripMenuItem.Text = "Hasta Kaydı";
            this.hastaKaydıToolStripMenuItem.Click += new System.EventHandler(this.hastaKaydıToolStripMenuItem_Click);
            // 
            // hastalarıListeleToolStripMenuItem
            // 
            this.hastalarıListeleToolStripMenuItem.Name = "hastalarıListeleToolStripMenuItem";
            this.hastalarıListeleToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.hastalarıListeleToolStripMenuItem.Text = "Hastaları Listele";
            this.hastalarıListeleToolStripMenuItem.Click += new System.EventHandler(this.hastalarıListeleToolStripMenuItem_Click);
            // 
            // hastaSilToolStripMenuItem
            // 
            this.hastaSilToolStripMenuItem.Name = "hastaSilToolStripMenuItem";
            this.hastaSilToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.hastaSilToolStripMenuItem.Text = "Hastayı Sil";
            this.hastaSilToolStripMenuItem.Click += new System.EventHandler(this.hastaSilToolStripMenuItem_Click);
            // 
            // hastayıGüncelleToolStripMenuItem
            // 
            this.hastayıGüncelleToolStripMenuItem.Name = "hastayıGüncelleToolStripMenuItem";
            this.hastayıGüncelleToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.hastayıGüncelleToolStripMenuItem.Text = "Hastayı Güncelle";
            this.hastayıGüncelleToolStripMenuItem.Click += new System.EventHandler(this.hastayıGüncelleToolStripMenuItem_Click);
            // 
            // ilaçlarToolStripMenuItem
            // 
            this.ilaçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilaçKaydıToolStripMenuItem,
            this.ilaçlarıListeleToolStripMenuItem,
            this.ilaçSilToolStripMenuItem,
            this.ilaçGüncelleToolStripMenuItem});
            this.ilaçlarToolStripMenuItem.Name = "ilaçlarToolStripMenuItem";
            this.ilaçlarToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.ilaçlarToolStripMenuItem.Text = "İlaçlar";
            // 
            // ilaçKaydıToolStripMenuItem
            // 
            this.ilaçKaydıToolStripMenuItem.Name = "ilaçKaydıToolStripMenuItem";
            this.ilaçKaydıToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.ilaçKaydıToolStripMenuItem.Text = "İlaç Kaydı";
            this.ilaçKaydıToolStripMenuItem.Click += new System.EventHandler(this.ilaçKaydıToolStripMenuItem_Click);
            // 
            // ilaçlarıListeleToolStripMenuItem
            // 
            this.ilaçlarıListeleToolStripMenuItem.Name = "ilaçlarıListeleToolStripMenuItem";
            this.ilaçlarıListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.ilaçlarıListeleToolStripMenuItem.Text = "İlaçları Listele";
            this.ilaçlarıListeleToolStripMenuItem.Click += new System.EventHandler(this.ilaçlarıListeleToolStripMenuItem_Click);
            // 
            // ilaçSilToolStripMenuItem
            // 
            this.ilaçSilToolStripMenuItem.Name = "ilaçSilToolStripMenuItem";
            this.ilaçSilToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.ilaçSilToolStripMenuItem.Text = "İlaç Sil";
            this.ilaçSilToolStripMenuItem.Click += new System.EventHandler(this.ilaçSilToolStripMenuItem_Click);
            // 
            // ilaçGüncelleToolStripMenuItem
            // 
            this.ilaçGüncelleToolStripMenuItem.Name = "ilaçGüncelleToolStripMenuItem";
            this.ilaçGüncelleToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.ilaçGüncelleToolStripMenuItem.Text = "İlaç Güncelle";
            this.ilaçGüncelleToolStripMenuItem.Click += new System.EventHandler(this.ilaçGüncelleToolStripMenuItem_Click);
            // 
            // güvenceToolStripMenuItem
            // 
            this.güvenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güvenceEkleToolStripMenuItem});
            this.güvenceToolStripMenuItem.Name = "güvenceToolStripMenuItem";
            this.güvenceToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.güvenceToolStripMenuItem.Text = "Güvence";
            // 
            // güvenceEkleToolStripMenuItem
            // 
            this.güvenceEkleToolStripMenuItem.Name = "güvenceEkleToolStripMenuItem";
            this.güvenceEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.güvenceEkleToolStripMenuItem.Text = "Güvence Ekle";
            this.güvenceEkleToolStripMenuItem.Click += new System.EventHandler(this.güvenceEkleToolStripMenuItem_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 316);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hasta TC : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Barkod No : ";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodNo.Location = new System.Drawing.Point(102, 79);
            this.txtBarkodNo.Mask = "0000000000";
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 26);
            this.txtBarkodNo.TabIndex = 5;
            this.txtBarkodNo.ValidatingType = typeof(int);
            // 
            // txtTcNo
            // 
            this.txtTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcNo.Location = new System.Drawing.Point(102, 48);
            this.txtTcNo.Mask = "00000000000";
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(112, 26);
            this.txtTcNo.TabIndex = 6;
            this.txtTcNo.ValidatingType = typeof(int);
            // 
            // numAdet
            // 
            this.numAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numAdet.Location = new System.Drawing.Point(320, 59);
            this.numAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(38, 26);
            this.numAdet.TabIndex = 7;
            this.numAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(259, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adet : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(456, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "SATIŞ YAP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numAdet);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECZANE OTOMASYONU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastalarıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastayıGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçlarıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güvenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güvenceEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtBarkodNo;
        private System.Windows.Forms.MaskedTextBox txtTcNo;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

