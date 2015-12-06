using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace FileRenamer
{
    public partial class FileRenamer : Form
    {

        private const int REGEXP_LIMIT = 3;
        private const int REPLACE_LIMIT = 6;
        private string current_path = null;
        private System.Windows.Forms.CheckBox[] checkBoxs;
        private System.Windows.Forms.TextBox[,] replaceTexts;

        private static Favorite favoriteForm;
        private static Config configForm;
        
        public FileRenamer()
        {
            InitializeComponent();

            //フォームの部品を配列に入れる
            this.checkBoxs = new System.Windows.Forms.CheckBox[REGEXP_LIMIT];
            this.checkBoxs[0] = this.checkBox1;
            this.checkBoxs[1] = this.checkBox2;
            this.checkBoxs[2] = this.checkBox3;

            this.replaceTexts = new System.Windows.Forms.TextBox[REGEXP_LIMIT, REPLACE_LIMIT];
            this.replaceTexts[0, 0] = this.replace11Text;
            this.replaceTexts[0, 1] = this.replace21Text;
            this.replaceTexts[0, 2] = this.replace31Text;
            this.replaceTexts[0, 3] = this.replace41Text;
            this.replaceTexts[0, 4] = this.replace51Text;
            this.replaceTexts[0, 5] = this.replace61Text;

            this.replaceTexts[1, 0] = this.replace12Text;
            this.replaceTexts[1, 1] = this.replace22Text;
            this.replaceTexts[1, 2] = this.replace32Text;
            this.replaceTexts[1, 3] = this.replace42Text;
            this.replaceTexts[1, 4] = this.replace52Text;
            this.replaceTexts[1, 5] = this.replace62Text;

            this.replaceTexts[2, 0] = this.replace13Text;
            this.replaceTexts[2, 1] = this.replace23Text;
            this.replaceTexts[2, 2] = this.replace33Text;
            this.replaceTexts[2, 3] = this.replace43Text;
            this.replaceTexts[2, 4] = this.replace53Text;
            this.replaceTexts[2, 5] = this.replace63Text;


            //フォームに保存しているデータを反映する
            ConfigData.getInstance().readFile(); //ファイル内容を反映

            string[] texts = ConfigData.getInstance().getExtractTexts();
            regexp1Text.Text = texts[0];
            regexp2Text.Text = texts[1];
            regexp3Text.Text = texts[2];

            string[,] multi_texts = ConfigData.getInstance().getReplaceTexts();
            for (int i = 0; i < REGEXP_LIMIT; i++)
            {
                for (int j = 0; j < REPLACE_LIMIT; j++)
                {
                    this.replaceTexts[i, j].Text = multi_texts[i, j];
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void setFilesInfo(string path)
        {
            //表を初期化
            fileView.Rows.Clear();

            //指定パスにあるファイルを取得する
            var fullpaths = System.IO.Directory.GetFiles(path, "*");
            foreach (var f in fullpaths)
            {
                //行をset
                fileView.Rows.Add(Path.GetFileName(f), "", "", "", f);

            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void convertButton_Click(object sender, EventArgs e)
        {
            //正規表現を適用するための事前準備
            System.Text.RegularExpressions.Regex[] regexp = new System.Text.RegularExpressions.Regex[REGEXP_LIMIT];
            try
            {
                regexp[0] = new System.Text.RegularExpressions.Regex(@regexp1Text.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                regexp[1] = new System.Text.RegularExpressions.Regex(@regexp2Text.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                regexp[2] = new System.Text.RegularExpressions.Regex(@regexp3Text.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            }
            catch
            {

            }

            //全ファイル名に対してREG_EXP_LIMIT分の正規表現をかける
            try
            {
                for (int i = 0; i < fileView.Rows.Count; i++)
                {
                    for (int j = 0; j < regexp.Length; j++)
                    {
                        string target = fileView.Rows[i].Cells[0].Value.ToString();
                        System.Text.RegularExpressions.Match m = regexp[j].Match(target);
                        fileView.Rows[i].Cells[j + 1].Value = m.Value.ToString();
                    }
                }
            }
            catch (System.NullReferenceException ex)
            {
                //確認ダイアログ
                MessageBox.Show(
                    "正規表現のエラー",
                    "確認",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);
            }

        }

        private void openPathMenu_Click(object sender, EventArgs e)
        {
            
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            dialog.EnsureReadOnly = false;
            dialog.AllowNonFileSystemItems = false;
            dialog.DefaultDirectory = Application.StartupPath;
            var result = dialog.ShowDialog();
            if(result == CommonFileDialogResult.Ok){
                this.Text = "File Renamer - " + dialog.FileName;
                current_path = dialog.FileName;
                setFilesInfo(dialog.FileName);
            }
            /*
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); //デフォルトをデスクトップのパスに
            //ダイアログを表示する
            
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                this.Text = "File Renamer - " + fbd.SelectedPath;
                current_path = fbd.SelectedPath;
                setFilesInfo(fbd.SelectedPath);
            }
            */
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < fileView.Rows.Count; i++)
                {
                    for (int j = 0; j < REGEXP_LIMIT; j++)
                    {
                        if (!checkBoxs[j].Checked)
                            continue;

                        string target = fileView.Rows[i].Cells[j + 1].Value.ToString(); //置換前
                        for (int k = 0; k < REPLACE_LIMIT / 2; k++)
                        {
                            string before = replaceTexts[j, 2 * k].Text;
                            string after = replaceTexts[j, 2 * k + 1].Text; //この文字に変更する

                            //正規表現
                            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(before);
                            System.Text.RegularExpressions.Match m = regex.Match(target);
                            before = m.Value.ToString();

                            after = after.Replace("%ss%", before); //特殊文字の反映

                            if (before.Length != 0)
                                target = target.Replace(before, after);
                        }
                        fileView.Rows[i].Cells[j + 1].Value = target;


                    }
                }
            }
            catch (System.ArgumentException ex)
            {
                //確認ダイアログ
                MessageBox.Show(
                    "正規表現のエラー",
                    "確認",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);
            }
        }

        private void renameMenu_Click(object sender, EventArgs e)
        {
            if (current_path == null)
                return;

            //確認ダイアログ
            DialogResult result = MessageBox.Show(
                "ファイルの名前を一括で変更しますか？",
                "確認",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Cancel)
                return;

            //リネーム．fullpathを見えない行が持っているので，それを使用する
            for (int i = 0; i < fileView.Rows.Count; i++)
            {
                string before = @fileView.Rows[i].Cells[REGEXP_LIMIT + 1].Value.ToString();
                string after = @fileView.Rows[i].Cells[0].Value.ToString();
                after = @current_path + @"\" + @after;
                System.IO.File.Move(@before, @after);
            }

            //確認ダイアログ
            MessageBox.Show(
                "変更が終了しました",
                "確認",
                MessageBoxButtons.OK,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button2);

            setFilesInfo(current_path); //fileView更新
        }


        private void selectReplaceButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell c in fileView.SelectedCells)
            {
                string target = fileView.Rows[c.RowIndex].Cells[c.ColumnIndex].Value.ToString(); //置換対象文字列
                string before = selectReplace1Text.Text;
                string after = selectReplace2Text.Text; //この文字に変更する

                if (before.Length != 0)
                    fileView.Rows[c.RowIndex].Cells[c.ColumnIndex].Value = target.Replace(before, after);
            }
        }

        private void selectUnionButton_Click(object sender, EventArgs e)
        {

            for (int r = 0; r < fileView.Rows.Count; r++)
            {

                string union = "";
                for (int c = 1; c <= REGEXP_LIMIT; c++)
                {
                    //選択されたセルがあれば
                    if (fileView.Rows[r].Cells[c].Selected)
                        union += fileView.Rows[r].Cells[c].Value.ToString();
                }
                //行に一つでも選択セルがあれば=unionが初期値でなければ
                if (union.Length != 0)
                    fileView.Rows[r].Cells[0].Value = union;
            }

        }

        public static Favorite favoriteFormInstance
        {
            get
            {
                //_instanceがnullまたは破棄されているときは、
                //新しくインスタンスを作成する
                if (favoriteForm == null || favoriteForm.IsDisposed)
                    favoriteForm = new Favorite();
                return favoriteForm;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            favoriteFormInstance.Show();
        }

        public static Config configFormInstance
        {
            get
            {
                //_instanceがnullまたは破棄されているときは、
                //新しくインスタンスを作成する
                if (configForm == null || configForm.IsDisposed)
                    configForm = new Config();
                return configForm;
            }
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            configFormInstance.Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void replace43Text_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
