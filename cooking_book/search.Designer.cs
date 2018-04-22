namespace cooking_book
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.rbtn_name = new System.Windows.Forms.RadioButton();
            this.rbtn_ingridient = new System.Windows.Forms.RadioButton();
            this.ltb_serch_result = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_back = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbtn_name
            // 
            this.rbtn_name.AutoSize = true;
            this.rbtn_name.Checked = true;
            this.rbtn_name.Location = new System.Drawing.Point(228, 76);
            this.rbtn_name.Name = "rbtn_name";
            this.rbtn_name.Size = new System.Drawing.Size(21, 20);
            this.rbtn_name.TabIndex = 5;
            this.rbtn_name.TabStop = true;
            this.rbtn_name.UseVisualStyleBackColor = true;
            // 
            // rbtn_ingridient
            // 
            this.rbtn_ingridient.AutoSize = true;
            this.rbtn_ingridient.Location = new System.Drawing.Point(521, 76);
            this.rbtn_ingridient.Name = "rbtn_ingridient";
            this.rbtn_ingridient.Size = new System.Drawing.Size(21, 20);
            this.rbtn_ingridient.TabIndex = 6;
            this.rbtn_ingridient.UseVisualStyleBackColor = true;
            // 
            // ltb_serch_result
            // 
            this.ltb_serch_result.BackColor = System.Drawing.Color.FloralWhite;
            this.ltb_serch_result.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ltb_serch_result.FormattingEnabled = true;
            this.ltb_serch_result.ItemHeight = 39;
            this.ltb_serch_result.Location = new System.Drawing.Point(26, 247);
            this.ltb_serch_result.Name = "ltb_serch_result";
            this.ltb_serch_result.Size = new System.Drawing.Size(556, 394);
            this.ltb_serch_result.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "Найти по:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 39);
            this.label2.TabIndex = 10;
            this.label2.Text = "наименованию";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(345, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "ингредиенту";
            // 
            // lb_back
            // 
            this.lb_back.AutoSize = true;
            this.lb_back.BackColor = System.Drawing.Color.Transparent;
            this.lb_back.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_back.Location = new System.Drawing.Point(164, 646);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(301, 49);
            this.lb_back.TabIndex = 12;
            this.lb_back.Text = "Вернуться в меню";
            this.lb_back.Click += new System.EventHandler(this.lb_back_Click);
            this.lb_back.MouseLeave += new System.EventHandler(this.mouse_off_item);
            this.lb_back.MouseHover += new System.EventHandler(this.mouse_on_item);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 49);
            this.label4.TabIndex = 13;
            this.label4.Text = "результат поиска:";
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.Color.FloralWhite;
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_search.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(26, 121);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(556, 36);
            this.tb_search.TabIndex = 7;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(608, 720);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltb_serch_result);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.rbtn_ingridient);
            this.Controls.Add(this.rbtn_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtn_name;
        private System.Windows.Forms.RadioButton rbtn_ingridient;
        private System.Windows.Forms.ListBox ltb_serch_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_back;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_search;
    }
}