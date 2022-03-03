namespace ProjectDungRun
{
    partial class MenuStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuStart));
            this.btnStart = new System.Windows.Forms.Button();
            this.txtTitleMenu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnStart.Font = new System.Drawing.Font("Engravers MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(180, 213);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(168, 60);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start New Game";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtTitleMenu
            // 
            this.txtTitleMenu.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtTitleMenu.Font = new System.Drawing.Font("Informal Roman", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleMenu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTitleMenu.Location = new System.Drawing.Point(33, 12);
            this.txtTitleMenu.Name = "txtTitleMenu";
            this.txtTitleMenu.Size = new System.Drawing.Size(505, 46);
            this.txtTitleMenu.TabIndex = 1;
            this.txtTitleMenu.Text = "Escape From Poorly Designed Dungeon";
            this.txtTitleMenu.TextChanged += new System.EventHandler(this.txtTitleMenu_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjectDungRun.Properties.Resources.menubg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtTitleMenu);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 298);
            this.panel1.TabIndex = 2;
            // 
            // MenuStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 285);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuStart";
            this.Text = "MenuStart";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.MenuStart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtTitleMenu;
        private System.Windows.Forms.Panel panel1;
    }
}