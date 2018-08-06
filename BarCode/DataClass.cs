using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Xml;
using System.Media;

namespace BarCode
{
    public class DataClass
    {
        private static string userid;
        private static string password;
        private static string server;
        public static string database;
        private static string errorText;

        public static void FromXml(string filename)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filename);
                XmlElement serverNode = (XmlElement)doc.GetElementsByTagName("Server")[0];
                server = serverNode.ChildNodes[0].Value;
                XmlElement databaseNode = (XmlElement)doc.GetElementsByTagName("Database")[0];
                database = databaseNode.ChildNodes[0].Value;
            }
            catch
            {
                server = "200.200.200.200";
                database = "Wise_Order";
            }
        }

        public static void PlaySound()
        {
            //System.Media.SoundPlayer sndPlayer = new  System.Media.SoundPlayer("\\Program Files\\barcode\\alarm3.wav");
            SoundPlayer sndPlayer = new SoundPlayer("OK.wav");
            sndPlayer.Play();
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public static string UserId
        {
            get
            {
                return userid;
            }
            set
            {
                userid = value;
            }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public static string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        /// <summary>
        /// 最近一条错误信息
        /// </summary>
        public static string ErrorText
        {
            get
            {
                return errorText;
            }
        }

        /// <summary>
        /// 查询数据，返回数据集
        /// </summary>
        /// <param name="selectcmd">查询语句</param>
        /// <returns></returns>
        public static DataSet GetData(string selectcmd)
        {
            errorText = "";
            DataSet ds = new DataSet();
            BarCode.DataService.DataService service = new BarCode.DataService.DataService();
             
            //System.Windows.Forms.MessageBox.Show(service.Timeout)
            BarCode.DataService.ReturnClass result = service.GetData(selectcmd, userid, password,server,database);
            if (result.IsOK)
            {
                string xml = (string)result.Value;
                StringReader reader = new StringReader(xml);
                XmlReader xr = XmlReader.Create(reader);
                ds.ReadXml(xr);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(result.Message);
                errorText = result.Message;
            }

            return ds;
        }

        /// <summary>
        /// 查询数据，返回第一个数据表
        /// </summary>
        /// <param name="selectcmd"></param>
        /// <returns></returns>
        public static DataTable GetTable(string selectcmd)
        {
            DataSet ds = GetData(selectcmd);
            if (ds.Tables.Count == 0)
            {
                DataTable table = new DataTable();
                return table;
            }
            return ds.Tables[0];
        }

        /// <summary>
        /// 执行命令
        /// </summary>
        /// <param name="commandtext">命令语句</param>
        public static bool Execute(string commandtext)
        {
            BarCode.DataService.ReturnClass result = new BarCode.DataService.ReturnClass();
            BarCode.DataService.DataService service = new BarCode.DataService.DataService();
            result = service.Execute(commandtext, userid, password,server,database);
            if (!result.IsOK)
            {
                errorText = result.Message;
            }
            return result.IsOK;
        }

        /// <summary>
        /// 检查用户有效性
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool CheckUser(string userid, string password)
        {
            BarCode.DataService.ReturnClass result = new BarCode.DataService.ReturnClass();
            BarCode.DataService.DataService service = new BarCode.DataService.DataService();
            
            result = service.CheckUser(userid, password,server,database);
            if (!result.IsOK)
            {
                errorText = result.Message;
            }
            return result.IsOK;
        }

        public static object GetValue(string selectcmd)
        {
            BarCode.DataService.ReturnClass result = new BarCode.DataService.ReturnClass();
            BarCode.DataService.DataService service = new BarCode.DataService.DataService();
            result = service.GetValue(selectcmd, userid, password,server,database);
            if (!result.IsOK)
            {
                errorText = result.Message;
            }
            return result.Value;
        }

        public static void ToXml(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.CreateXmlDeclaration("1.0", null, "yes");
            XmlElement root = doc.CreateElement("Config");
            XmlElement serverNode = doc.CreateElement("Server");
            serverNode.AppendChild(doc.CreateTextNode(server));
            XmlElement databaseNode = doc.CreateElement("Database");
            databaseNode.AppendChild(doc.CreateTextNode(database));
            root.AppendChild(serverNode);
            root.AppendChild(databaseNode);
            doc.AppendChild(root);
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter wr = XmlWriter.Create(filename,settings);
            doc.WriteTo(wr);
            wr.Flush();
            wr.Close();
        }
    }
}
