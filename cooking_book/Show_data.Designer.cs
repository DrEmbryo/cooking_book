namespace cooking_book
{
    partial class Show_data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_data));
            this.rtb_show_data = new System.Windows.Forms.RichTextBox();
            this.lb_back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_show_data
            // 
            this.rtb_show_data.BackColor = System.Drawing.Color.FloralWhite;
            this.rtb_show_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_show_data.Location = new System.Drawing.Point(13, 13);
            this.rtb_show_data.Name = "rtb_show_data";
            this.rtb_show_data.Size = new System.Drawing.Size(1255, 610);
            this.rtb_show_data.TabIndex = 0;
            this.rtb_show_data.Text = "";
            // 
            // lb_back
            // 
            this.lb_back.AutoSize = true;
            this.lb_back.BackColor = System.Drawing.Color.Transparent;
            this.lb_back.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_back.Location = new System.Drawing.Point(468, 647);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(301, 49);
            this.lb_back.TabIndex = 1;
            this.lb_back.Text = "Вернуться в меню";
            this.lb_back.Click += new System.EventHandler(this.lb_back_Click);
            this.lb_back.MouseLeave += new System.EventHandler(this.mouse_off_item);
            this.lb_back.MouseHover += new System.EventHandler(this.mouse_on_item);
            // 
            // Show_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lb_back);
            this.Controls.Add(this.rtb_show_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Show_data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show_data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_show_data;
        private System.Windows.Forms.Label lb_back;
    }
}