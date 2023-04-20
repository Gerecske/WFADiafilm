namespace WFADiafilm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBMain = new System.Windows.Forms.TextBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kocka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TBMain
            // 
            this.TBMain.Location = new System.Drawing.Point(12, 12);
            this.TBMain.Name = "TBMain";
            this.TBMain.Size = new System.Drawing.Size(776, 23);
            this.TBMain.TabIndex = 0;
            this.TBMain.TextChanged += new System.EventHandler(this.TBMain_TextChanged);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cim,
            this.ev,
            this.kocka,
            this.szines,
            this.nev});
            this.DGV.Location = new System.Drawing.Point(12, 41);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowTemplate.Height = 25;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(776, 150);
            this.DGV.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // cim
            // 
            this.cim.HeaderText = "cím";
            this.cim.Name = "cim";
            this.cim.ReadOnly = true;
            // 
            // ev
            // 
            this.ev.HeaderText = "kiadási év";
            this.ev.Name = "ev";
            this.ev.ReadOnly = true;
            // 
            // kocka
            // 
            this.kocka.HeaderText = " képkockaszám";
            this.kocka.Name = "kocka";
            this.kocka.ReadOnly = true;
            // 
            // szines
            // 
            this.szines.HeaderText = "színes";
            this.szines.Name = "szines";
            this.szines.ReadOnly = true;
            // 
            // nev
            // 
            this.nev.HeaderText = "kiadó neve";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.TBMain);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TBMain;
        private DataGridView DGV;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn cim;
        private DataGridViewTextBoxColumn ev;
        private DataGridViewTextBoxColumn kocka;
        private DataGridViewTextBoxColumn szines;
        private DataGridViewTextBoxColumn nev;
    }
}