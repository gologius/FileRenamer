using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileRenamer
{
    public partial class Favorite : Form
    {
        List<string[]> rows = new List<string[]>();

        public Favorite()
        {
            InitializeComponent();
            
            //ファイルから設定を読み込む
            
            
            rows.Add(new string[]{"sex","manjkio"});
            rows.Add(new string[]{"seeex","manjkfeio"});
            rows.Add(new string[]{"sex","manjkfwefio"});
            rows.Add(new string[]{"seeeex","manjfwekio"});

            foreach (var item in rows)
            {
                commandView.Rows.Add(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void commandView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
