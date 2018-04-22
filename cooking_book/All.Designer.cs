namespace cooking_book
{
    partial class All
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(All));
            this.lb_back = new System.Windows.Forms.Label();
            this.lbs_show_all = new System.Windows.Forms.ListBox();
            this.lb_details = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_back
            // 
            this.lb_back.AutoSize = true;
            this.lb_back.BackColor = System.Drawing.Color.Transparent;
            this.lb_back.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_back.Location = new System.Drawing.Point(33, 650);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(301, 49);
            this.lb_back.TabIndex = 0;
            this.lb_back.Text = "Вернуться в меню";
            this.lb_back.Click += new System.EventHandler(this.lb_back_Click);
            this.lb_back.MouseLeave += new System.EventHandler(this.mouse_off_item);
            this.lb_back.MouseHover += new System.EventHandler(this.mouse_on_item);
            // 
            // lbs_show_all
            // 
            this.lbs_show_all.BackColor = System.Drawing.Color.FloralWhite;
            this.lbs_show_all.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbs_show_all.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbs_show_all.FormattingEnabled = true;
            this.lbs_show_all.ItemHeight = 34;
            this.lbs_show_all.Location = new System.Drawing.Point(35, 32);
            this.lbs_show_all.Name = "lbs_show_all";
            this.lbs_show_all.Size = new System.Drawing.Size(299, 544);
            this.lbs_show_all.TabIndex = 1;
            // 
            // lb_details
            // 
            this.lb_details.AutoSize = true;
            this.lb_details.BackColor = System.Drawing.Color.Transparent;
            this.lb_details.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_details.Location = new System.Drawing.Point(100, 601);
            this.lb_details.Name = "lb_details";
            this.lb_details.Size = new System.Drawing.Size(177, 49);
            this.lb_details.TabIndex = 2;
            this.lb_details.Text = "Подробнее";
            this.lb_details.Click += new System.EventHandler(this.sent_to_show_data);
            this.lb_details.MouseLeave += new System.EventHandler(this.mouse_off_item);
            this.lb_details.MouseHover += new System.EventHandler(this.mouse_on_item);
            // 
            // All
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(381, 720);
            this.ControlBox = false;
            this.Controls.Add(this.lb_details);
            this.Controls.Add(this.lbs_show_all);
            this.Controls.Add(this.lb_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "All";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All";
            this.Load += new System.EventHandler(this.show_all_files);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_back;
        private System.Windows.Forms.ListBox lbs_show_all;
        private System.Windows.Forms.Label lb_details;
    }
}