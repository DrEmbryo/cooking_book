using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace cooking_book
{
    public partial class Search : Form
    {
        public Button Enter = new Button();

        public List<string> filelist = new List<string>();

        public Search(List<string> filelist)
        {
            InitializeComponent();
            this.filelist = filelist;
            Enter.Click += new EventHandler(sort_choise);
            this.AcceptButton = Enter;
        }

        private void search_by_name(object sender, EventArgs e)
        {
            foreach (var i in filelist)
            {
                if (tb_search.Text == i)
                {
                    ltb_serch_result.Items.Add(i);
                }
            }
        }

        private void search_by_ingridient(object sender, EventArgs e)
        {
            foreach (var i in filelist)
            {
                string path = "files\\" + i + ".rtf";

                RichTextBox rt = new RichTextBox();
                rt.LoadFile(path, System.Windows.Forms.RichTextBoxStreamType.RichText);

                foreach (string line in rt.Lines)
                {
                    if(line == "***")
                    {
                        break;
                    }
                    else if (line == tb_search.Text)
                    {
                        ltb_serch_result.Items.Add(i);
                    }
                }

            }
        }

        private void sort_choise(object sender, EventArgs e)
        {
            ltb_serch_result.Items.Clear();

            if (rbtn_name.Checked)
            {
                search_by_name(sender , e);
            }
            else if (rbtn_ingridient.Checked)
            {
                search_by_ingridient(sender, e);
            }
        }

        private void sent_to_show_data(object sender, EventArgs e)
        {
            if (ltb_serch_result.SelectedIndex < 0)
            {
                MessageBox.Show("Ошибка!");
            }
            else {
                string selected_file = "files\\" + ltb_serch_result.SelectedItem.ToString() + ".rtf";
                Show_data form = new Show_data(selected_file);
                form.Disposed += new EventHandler(childIsClosed);
                this.Hide();
                form.ShowDialog();
            }
        }

        private void childIsClosed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void lb_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void mouse_on_item(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font("Monotype Corsiva", 20, FontStyle.Underline);
        }

        public void mouse_off_item(object sender, EventArgs e)
        {
            (sender as Label).Font = new Font("Monotype Corsiva", 20, FontStyle.Regular);
        }
    }
}
