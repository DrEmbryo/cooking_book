namespace cooking_book
{
    partial class Main_menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_menu));
            this.label1 = new System.Windows.Forms.Label();
            this.lb_show_all = new System.Windows.Forms.Label();
            this.lb_search = new System.Windows.Forms.Label();
            this.lb_exit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Электронная книга рецептов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_show_all
            // 
            this.lb_show_all.AutoSize = true;
            this.lb_show_all.BackColor = System.Drawing.Color.Transparent;
            this.lb_show_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_show_all.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_show_all.Location = new System.Drawing.Point(183, 171);
            this.lb_show_all.Name = "lb_show_all";
            this.lb_show_all.Size = new System.Drawing.Size(410, 49);
            this.lb_show_all.TabIndex = 1;
            this.lb_show_all.Text = "Посмотреть все рецепты";
            this.lb_show_all.Click += new System.EventHandler(this.lb_show_all_Click);
            this.lb_show_all.MouseLeave += new System.EventHandler(this.mouse_off_item);
            this.lb_show_all.MouseHover += new System.EventHandler(this.mouse_on_item);
            // 
            // lb_search
            // 
            this.lb_search.AutoSize = true;
            this.lb_search.BackColor = System.Drawing.Color.Transparent;
            this.lb_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_search.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_search.Location = new System.Drawing.Point(255, 235);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(243, 49);
            this.lb_search.TabIndex = 2;
            this.lb_search.Text = "Найти рецепт";
            this.lb_search.Click += new System.EventHandler(this.lb_search_Click);
            this.lb_search.MouseLeave += new System.EventHandler(this.mouse_off_item);
            this.lb_search.MouseHover += new System.EventHandler(this.mouse_on_item);
            // 
            // lb_exit
            // 
            this.lb_exit.AutoSize = true;
            this.lb_exit.BackColor = System.Drawing.Color.Transparent;
            this.lb_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_exit.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_exit.Location = new System.Drawing.Point(247, 296);
            this.lb_exit.Name = "lb_exit";
            this.lb_exit.Size = new System.Drawing.Size(254, 49);
            this.lb_exit.TabIndex = 3;
            this.lb_exit.Text = "Закрыть книгу";
            this.lb_exit.Click += new System.EventHandler(this.lb_exit_Click);
            this.lb_exit.MouseLeave += new System.EventHandler(this.mouse_off_item);
            this.lb_exit.MouseHover += new System.EventHandler(this.mouse_on_item);
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(750, 462);
            this.ControlBox = false;
            this.Controls.Add(this.lb_exit);
            this.Controls.Add(this.lb_search);
            this.Controls.Add(this.lb_show_all);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_show_all;
        private System.Windows.Forms.Label lb_search;
        private System.Windows.Forms.Label lb_exit;
    }
}

