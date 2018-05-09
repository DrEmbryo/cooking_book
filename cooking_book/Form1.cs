using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace cooking_book
{
    public partial class Main_menu : Form
    {
        List<string> files = new List<string>();
        public Main_menu()
        {
            InitializeComponent();
        }

        private void lb_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_show_all_Click(object sender, EventArgs e)
        {
            All all_form = new All(files);
            this.Hide();
            all_form.Disposed += new EventHandler(closed);
            all_form.Show();
        }

        public void mouse_on_item(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font("Monotype Corsiva", 20, FontStyle.Underline);
        }

        public void mouse_off_item(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font("Monotype Corsiva", 20, FontStyle.Regular);
        }
  
        public void closed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void lb_search_Click(object sender, EventArgs e)
        {
            Search searc_form = new Search(files);
            this.Hide();
            searc_form.Disposed += new EventHandler(closed);
            searc_form.Show();
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {
            string[] allfiles = Directory.GetFiles("files", "*.rtf", SearchOption.AllDirectories);

            string[] splited = null;
            string split_string = null;
            for (int i = 0; i < allfiles.Length; i++)
            {
                split_string = allfiles[i];
                splited = split_string.Split('/');
                splited = splited[splited.Length - 1].Split(new char[] { '.', '\\' }); 
                files.Add(splited[1]);
            }
        }
    }
}
