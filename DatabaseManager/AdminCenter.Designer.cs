
namespace DatabaseManager
{
    partial class AdminCenter
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
            this.pnlRoundedBorder = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlFiller = new System.Windows.Forms.Panel();
            this.panelControlContainer = new System.Windows.Forms.Panel();
            this.navSales = new Guna.UI2.WinForms.Guna2TileButton();
            this.navHome = new Guna.UI2.WinForms.Guna2TileButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlRoundedBorder.SuspendLayout();
            this.panelControlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRoundedBorder
            // 
            this.pnlRoundedBorder.BorderRadius = 30;
            this.pnlRoundedBorder.Controls.Add(this.pnlFiller);
            this.pnlRoundedBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRoundedBorder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.pnlRoundedBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlRoundedBorder.Name = "pnlRoundedBorder";
            this.pnlRoundedBorder.ShadowDecoration.Parent = this.pnlRoundedBorder;
            this.pnlRoundedBorder.Size = new System.Drawing.Size(83, 450);
            this.pnlRoundedBorder.TabIndex = 0;
            // 
            // pnlFiller
            // 
            this.pnlFiller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.pnlFiller.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFiller.Location = new System.Drawing.Point(0, 0);
            this.pnlFiller.Name = "pnlFiller";
            this.pnlFiller.Size = new System.Drawing.Size(38, 450);
            this.pnlFiller.TabIndex = 0;
            // 
            // panelControlContainer
            // 
            this.panelControlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.panelControlContainer.Controls.Add(this.navSales);
            this.panelControlContainer.Controls.Add(this.navHome);
            this.panelControlContainer.Location = new System.Drawing.Point(0, 25);
            this.panelControlContainer.Name = "panelControlContainer";
            this.panelControlContainer.Size = new System.Drawing.Size(80, 401);
            this.panelControlContainer.TabIndex = 1;
            // 
            // navSales
            // 
            this.navSales.BackColor = System.Drawing.Color.Transparent;
            this.navSales.BorderRadius = 10;
            this.navSales.CheckedState.Parent = this.navSales;
            this.navSales.CustomImages.Parent = this.navSales;
            this.navSales.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.navSales.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.navSales.ForeColor = System.Drawing.Color.White;
            this.navSales.HoverState.Parent = this.navSales;
            this.navSales.Image = global::DatabaseManager.Properties.Resources.sales_100px;
            this.navSales.ImageSize = new System.Drawing.Size(40, 40);
            this.navSales.Location = new System.Drawing.Point(12, 77);
            this.navSales.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.navSales.Name = "navSales";
            this.navSales.ShadowDecoration.BorderRadius = 10;
            this.navSales.ShadowDecoration.Color = System.Drawing.Color.White;
            this.navSales.ShadowDecoration.Depth = 10;
            this.navSales.ShadowDecoration.Enabled = true;
            this.navSales.ShadowDecoration.Parent = this.navSales;
            this.navSales.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.navSales.Size = new System.Drawing.Size(56, 53);
            this.navSales.TabIndex = 5;
            this.navSales.Click += new System.EventHandler(this.ResetSelectedNavItem);
            // 
            // navHome
            // 
            this.navHome.BackColor = System.Drawing.Color.Transparent;
            this.navHome.BorderRadius = 10;
            this.navHome.CheckedState.Parent = this.navHome;
            this.navHome.CustomImages.Parent = this.navHome;
            this.navHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(84)))), ((int)(((byte)(92)))));
            this.navHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.navHome.ForeColor = System.Drawing.Color.White;
            this.navHome.HoverState.Parent = this.navHome;
            this.navHome.Image = global::DatabaseManager.Properties.Resources.home_page_100px;
            this.navHome.ImageSize = new System.Drawing.Size(40, 40);
            this.navHome.Location = new System.Drawing.Point(13, 13);
            this.navHome.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.navHome.Name = "navHome";
            this.navHome.ShadowDecoration.BorderRadius = 10;
            this.navHome.ShadowDecoration.Color = System.Drawing.Color.White;
            this.navHome.ShadowDecoration.Depth = 10;
            this.navHome.ShadowDecoration.Enabled = true;
            this.navHome.ShadowDecoration.Parent = this.navHome;
            this.navHome.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.navHome.Size = new System.Drawing.Size(56, 53);
            this.navHome.TabIndex = 4;
            this.navHome.Click += new System.EventHandler(this.ResetSelectedNavItem);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AdminCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelControlContainer);
            this.Controls.Add(this.pnlRoundedBorder);
            this.Name = "AdminCenter";
            this.Text = "AdminCenter";
            this.pnlRoundedBorder.ResumeLayout(false);
            this.panelControlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlRoundedBorder;
        private System.Windows.Forms.Panel pnlFiller;
        private System.Windows.Forms.Panel panelControlContainer;
        private Guna.UI2.WinForms.Guna2TileButton navHome;
        private Guna.UI2.WinForms.Guna2TileButton navSales;
        private System.Windows.Forms.Button button1;
    }
}