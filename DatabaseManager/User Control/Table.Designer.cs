
namespace DatabaseManager.User_Control
{
    partial class Table
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnWipe = new Guna.UI2.WinForms.Guna2Button();
            this.lblTableName = new Guna.UI.WinForms.GunaLabel();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnWipe);
            this.guna2ShadowPanel1.Controls.Add(this.lblTableName);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 50;
            this.guna2ShadowPanel1.ShadowShift = 4;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(260, 60);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // btnWipe
            // 
            this.btnWipe.BackColor = System.Drawing.Color.Transparent;
            this.btnWipe.BorderRadius = 10;
            this.btnWipe.CheckedState.Parent = this.btnWipe;
            this.btnWipe.CustomImages.Parent = this.btnWipe;
            this.btnWipe.FillColor = System.Drawing.Color.White;
            this.btnWipe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWipe.ForeColor = System.Drawing.Color.Red;
            this.btnWipe.HoverState.Parent = this.btnWipe;
            this.btnWipe.Location = new System.Drawing.Point(197, 11);
            this.btnWipe.Name = "btnWipe";
            this.btnWipe.ShadowDecoration.BorderRadius = 10;
            this.btnWipe.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.btnWipe.ShadowDecoration.Depth = 10;
            this.btnWipe.ShadowDecoration.Enabled = true;
            this.btnWipe.ShadowDecoration.Parent = this.btnWipe;
            this.btnWipe.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnWipe.Size = new System.Drawing.Size(47, 34);
            this.btnWipe.TabIndex = 1;
            this.btnWipe.Text = "WIPE";
            this.btnWipe.Click += new System.EventHandler(this.btnWipe_Click);
            // 
            // lblTableName
            // 
            this.lblTableName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTableName.Location = new System.Drawing.Point(9, 2);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(177, 51);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "gunaLabel1";
            this.lblTableName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "Table";
            this.Size = new System.Drawing.Size(260, 60);
            this.Load += new System.EventHandler(this.Table_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI.WinForms.GunaLabel lblTableName;
        private Guna.UI2.WinForms.Guna2Button btnWipe;
    }
}
