
namespace DatabaseManager
{
    partial class Query
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuery = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnRun = new Guna.UI2.WinForms.Guna2Button();
            this.dgvQueryResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResult)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 372);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "LIST OF TABLES";
            // 
            // txtQuery
            // 
            this.txtQuery.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuery.DefaultText = "";
            this.txtQuery.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuery.DisabledState.Parent = this.txtQuery;
            this.txtQuery.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuery.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuery.FocusedState.Parent = this.txtQuery;
            this.txtQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuery.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuery.HoverState.Parent = this.txtQuery;
            this.txtQuery.Location = new System.Drawing.Point(273, 3);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.PasswordChar = '\0';
            this.txtQuery.PlaceholderText = "";
            this.txtQuery.SelectedText = "";
            this.txtQuery.ShadowDecoration.Depth = 10;
            this.txtQuery.ShadowDecoration.Enabled = true;
            this.txtQuery.ShadowDecoration.Parent = this.txtQuery;
            this.txtQuery.Size = new System.Drawing.Size(518, 59);
            this.txtQuery.TabIndex = 5;
            this.txtQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuery_KeyDown);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(226, 4);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(42, 15);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Query:";
            // 
            // btnRun
            // 
            this.btnRun.CheckedState.Parent = this.btnRun;
            this.btnRun.CustomImages.Parent = this.btnRun;
            this.btnRun.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.HoverState.Parent = this.btnRun;
            this.btnRun.Location = new System.Drawing.Point(798, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.ShadowDecoration.Parent = this.btnRun;
            this.btnRun.Size = new System.Drawing.Size(69, 58);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "RUN (F5)";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // dgvQueryResult
            // 
            this.dgvQueryResult.AllowUserToAddRows = false;
            this.dgvQueryResult.AllowUserToDeleteRows = false;
            this.dgvQueryResult.AllowUserToOrderColumns = true;
            this.dgvQueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueryResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQueryResult.Location = new System.Drawing.Point(185, 69);
            this.dgvQueryResult.Name = "dgvQueryResult";
            this.dgvQueryResult.ReadOnly = true;
            this.dgvQueryResult.Size = new System.Drawing.Size(682, 372);
            this.dgvQueryResult.TabIndex = 8;
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 448);
            this.Controls.Add(this.dgvQueryResult);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Query";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query";
            this.Load += new System.EventHandler(this.Query_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtQuery;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Button btnRun;
        private System.Windows.Forms.DataGridView dgvQueryResult;
    }
}