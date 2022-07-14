namespace Project_Apple
{
    partial class User_DX
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDX = new Guna.UI2.WinForms.Guna2Button();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnDX
            // 
            this.btnDX.CheckedState.Parent = this.btnDX;
            this.btnDX.CustomImages.Parent = this.btnDX;
            this.btnDX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDX.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDX.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDX.ForeColor = System.Drawing.Color.White;
            this.btnDX.HoverState.Parent = this.btnDX;
            this.btnDX.Location = new System.Drawing.Point(0, 0);
            this.btnDX.Name = "btnDX";
            this.btnDX.ShadowDecoration.Parent = this.btnDX;
            this.btnDX.Size = new System.Drawing.Size(228, 48);
            this.btnDX.TabIndex = 0;
            this.btnDX.Text = "Thoát";
            this.btnDX.Click += new System.EventHandler(this.btnDX_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // User_DX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "User_DX";
            this.Size = new System.Drawing.Size(228, 48);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnDX;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}
