using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace cooking_book
{
    public partial class All : Form
    {
        public List<string> filelist = new List<string>();

        public All(List<string> filelist)
        {
            InitializeComponent();
            this.filelist = filelist;
        }

        private void lb_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mouse_on_item(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font("Monotype Corsiva", 20, FontStyle.Underline);
        }

        private void mouse_off_item(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font("Monotype Corsiva", 20, FontStyle.Regular);
        }

        private void show_all_files(object sender, EventArgs e)
        {
            foreach (var i in filelist)
            {
                lbs_show_all.Items.Add(i);
            }
            hide_button(sender, e);
        }

        private void hide_button(object sender, EventArgs e)
        {
            int selected = lbs_show_all.SelectedIndex;

            if (lbs_show_all.Items.Count < 0)
            {
                lb_details.Visible = false;
            }
        }

        private void sent_to_show_data(object sender, EventArgs e)
        {
            int selected_file_index = lbs_show_all.SelectedIndex;
            string[] allfiles = Directory.GetFiles("files", "*.rtf", SearchOption.AllDirectories);
            string selected_file = allfiles[selected_file_index];
            Show_data form = new Show_data(selected_file);
            form.Disposed += new EventHandler(childIsClosed);
            this.Hide();
            form.ShowDialog();
        }

        private void childIsClosed(object sender, EventArgs e) {
            this.Show();
        }
    }
}

