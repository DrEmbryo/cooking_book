using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace cooking_book
{
    public partial class Show_data : Form
    {
        public Show_data(string selected_file)
        {
            InitializeComponent();
            rtb_show_data.LoadFile(selected_file);
        }

        private void mouse_on_item(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font("Monotype Corsiva", 20, FontStyle.Underline);
        }

        private void mouse_off_item(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font("Monotype Corsiva", 20, FontStyle.Regular);
        }

        private void lb_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
