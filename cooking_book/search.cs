using System;
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

        private void sort_choise(object sender, EventArgs e)
        {
            ltb_serch_result.Items.Clear();

            if (rbtn_name.Checked)
            {
                search_by_name(sender , e);
            }
            else if (rbtn_ingridient.Checked)
            {
                // search by ingridient method
            }
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
