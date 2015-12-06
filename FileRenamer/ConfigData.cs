using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileRenamer
{
    [Serializable()]
    public class ConfigData
    {
        public const int REGEXP_LIMIT = 3;
        public const int REPLACE_LIMIT = 6;

        private string fileName = "config.xml";
        public string[,] replaceTexts = new string[REGEXP_LIMIT, REPLACE_LIMIT];
        public string[] extractTexts = new string[REGEXP_LIMIT];
        public string regexpResultText = "%ss%";

        private static ConfigData instance = new ConfigData();

        private ConfigData()
        {
        }

        public static ConfigData getInstance()
        {
            return instance;
        }


        public void setReplaceTexts(string[,] _replaceTexts)
        {
            //配列の大きさチェック
            if (_replaceTexts.GetLength(0) != REGEXP_LIMIT || _replaceTexts.GetLength(1) != REPLACE_LIMIT)
                return;

            Array.Copy(_replaceTexts, replaceTexts, _replaceTexts.Length);
            replaceTexts = (string[,])_replaceTexts.Clone(); //配列のコピー
        }

        public string[,] getReplaceTexts()
        {
            return replaceTexts;
        }

        public void setExtractTexts(string[] _extractTexts)
        {
            if (_extractTexts.GetLength(0) != REGEXP_LIMIT)
                return;

            _extractTexts.CopyTo(extractTexts, 0);
        }

        public string[] getExtractTexts()
        {
            return extractTexts;
        }

        public void setRegexpResultText(string _regexpResultText)
        {
            regexpResultText = _regexpResultText;
        }

        public string getRegexpResultText()
        {
            return regexpResultText;
        }

        public void readFile()
        {
            FileStream fs = new FileStream(
                fileName,
                FileMode.Open,
                FileAccess.Read);
            BinaryFormatter f = new BinaryFormatter();
            instance = (ConfigData)f.Deserialize(fs);
            fs.Close();
        }

        public void writeFile()
        {
            FileStream fs = new FileStream(
                fileName,
                FileMode.Create,
                FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, instance);
            fs.Close();
        }

    }
}
