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
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
            ConfigData.getInstance().readFile();
            string[] extractTexts = ConfigData.getInstance().getExtractTexts();
            extract1Text.Text = extractTexts[0];
            extract2Text.Text = extractTexts[1];
            extract3Text.Text = extractTexts[2];

            string[,] replaceTexts = ConfigData.getInstance().getReplaceTexts();
            replace11Text.Text = replaceTexts[0, 0];
            replace21Text.Text = replaceTexts[0, 1];
            replace31Text.Text = replaceTexts[0, 2];
            replace41Text.Text = replaceTexts[0, 3];
            replace51Text.Text = replaceTexts[0, 4];
            replace61Text.Text = replaceTexts[0, 4];
            
            replace12Text.Text = replaceTexts[1, 0];
            replace22Text.Text = replaceTexts[1, 1];
            replace32Text.Text = replaceTexts[1, 2];
            replace42Text.Text = replaceTexts[1, 3];
            replace52Text.Text = replaceTexts[1, 4];
            replace62Text.Text = replaceTexts[1, 5];

            replace13Text.Text = replaceTexts[2, 0];
            replace23Text.Text = replaceTexts[2, 1];
            replace33Text.Text = replaceTexts[2, 2];
            replace43Text.Text = replaceTexts[2, 3];
            replace53Text.Text = replaceTexts[2, 4];
            replace63Text.Text = replaceTexts[2, 5];

            regexpResultText.Text = ConfigData.getInstance().getRegexpResultText();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            string[,] replaceTexts = new string[ConfigData.REGEXP_LIMIT, ConfigData.REPLACE_LIMIT];
            replaceTexts[0, 0] = replace11Text.Text;
            replaceTexts[0, 1] = replace21Text.Text;
            replaceTexts[0, 2] = replace31Text.Text;
            replaceTexts[0, 3] = replace41Text.Text;
            replaceTexts[0, 4] = replace51Text.Text;
            replaceTexts[0, 5] = replace61Text.Text;

            replaceTexts[1, 0] = replace12Text.Text;
            replaceTexts[1, 1] = replace22Text.Text;
            replaceTexts[1, 2] = replace32Text.Text;
            replaceTexts[1, 3] = replace42Text.Text;
            replaceTexts[1, 4] = replace52Text.Text;
            replaceTexts[1, 5] = replace62Text.Text;

            replaceTexts[2, 0] = replace13Text.Text;
            replaceTexts[2, 1] = replace23Text.Text;
            replaceTexts[2, 2] = replace33Text.Text;
            replaceTexts[2, 3] = replace43Text.Text;
            replaceTexts[2, 4] = replace53Text.Text;
            replaceTexts[2, 5] = replace63Text.Text;
            ConfigData.getInstance().setReplaceTexts(replaceTexts);

            string[] extractTexts = new string[ConfigData.REGEXP_LIMIT];
            extractTexts[0] = extract1Text.Text;
            extractTexts[1] = extract2Text.Text;
            extractTexts[2] = extract3Text.Text;
            ConfigData.getInstance().setExtractTexts(extractTexts);

            ConfigData.getInstance().setRegexpResultText(regexpResultText.Text);

            ConfigData.getInstance().writeFile();

            //確認ダイアログ
            MessageBox.Show(
                "ファイルに保存しました",
                "確認",
                MessageBoxButtons.OK,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button2);
           
        }
    }
}
