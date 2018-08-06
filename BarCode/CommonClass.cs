using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Media;

namespace BarCode
{
    public class CommonClass
    {

        public static string pUserID;

        public static string sUserID
        {
            get
            {
                return pUserID;
            }
            set
            {
                pUserID = value;
            }
        }

 

        /// <summary>
        /// 播放OK声音
        /// </summary>
        public static void PlaySoundOK()
        {
            PlaySound(true);
        }

        /// <summary>
        /// 播放NG声音
        /// </summary>
        public static void PlaySoundNG()
        {
            PlaySound(false);
        }

        public static void PlaySound(bool isOK)
        {
            string strSoundFile;
            if (isOK == true)
            {
                strSoundFile = "\\Program Files\\BarCode\\Media\\OK.wav";
            }
            else
            {
                strSoundFile = "\\Program Files\\BarCode\\Media\\NG.wav";
            }
            SoundPlayer player = new SoundPlayer(strSoundFile);
            player.Play();
        }
        /// <summary>
        /// 检查仓位号
        /// </summary>
        /// <param name="strCWH">cwh</param>
        /// <returns></returns>
        public static bool CheckCWH(string strCWH)
        {
            string selectcmd = "if exists(select * from 仓位表2    with(nolock)  where 格子号='" + strCWH + "')";
            selectcmd += "\n    select 1";
            selectcmd += "\n else";
            selectcmd += "\n    select 0";
            if ((int)DataClass.GetValue(selectcmd) == 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 检查箱号条码,来源：仓位库存表
        /// </summary>
        /// <param name="strXHTM">箱号条码</param>
        /// <returns></returns>
        public static bool CheckXHTM(string strXHTM)
        {

            string selectcmd = "if exists(select * from 仓位库存表  with(nolock)  where 箱号条码='" + strXHTM + "')";
            selectcmd += "\n    select 1";
            selectcmd += "\n else";
            selectcmd += "\n    select 0";
            if ((int)DataClass.GetValue(selectcmd) == 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 检查是否新的空白箱号条码，来源：仓位库存表
        /// </summary>
        /// <param name="strXHTM">箱号条码</param>
        /// <returns></returns>
        public static bool CheckNewXHTM(string strXHTM)
        {
            string selectcmd = "if dbo.是否空白箱号条码('" + strXHTM  + "')=1";
            selectcmd += "\n    select 1";
            selectcmd += "\n else";
            selectcmd += "\n    select 0";
            if ((int)DataClass.GetValue(selectcmd) == 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 检查箱号条码,来源：仓位库存表
        /// </summary>
        /// <param name="strXHTM">箱号条码</param>
        /// <returns></returns>
        public static bool CheckXHTM2(string strXHTM)
        {
            string selectcmd = "if exists(select * from 仓位库存表  with(nolock)  where 箱号条码='" + strXHTM + "')";
            selectcmd += "\n    select 1";
            selectcmd += "\n else";
            selectcmd += "\n    select 0";
            if ((int)DataClass.GetValue(selectcmd) == 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 根据箱号条码查询材料编号
        /// </summary>
        /// <param name="strXHTM">箱号条码</param>
        /// <returns></returns>
        public static string GetCLBH(string strXHTM)
        {
            string strCLBH = (string)DataClass.GetValue("select 材料编号 from 仓位库存表  with(nolock)  where 箱号条码='" + strXHTM + "'");
            //string strLLPC = GetLLPC(strXHTM);
            //string strCLBH = (string)DataClass.GetValue("select clbh from m_clmx where llpc='" + strLLPC + "'");
            if (strCLBH == null)
                strCLBH = "";
            return strCLBH;
        }

        /// <summary>
        /// 根据箱号条码查询来料批次
        /// </summary>
        /// <param name="strXHTM">箱号条码</param>
        /// <returns></returns>
        public static string GetLLPC(string strXHTM)
        {
            string strLLPC = (string)DataClass.GetValue("select 来料批次 from 仓位库存表  with(nolock)  where 箱号条码='" + strXHTM + "'");
            if (strLLPC == null)
                strLLPC = "";
            return strLLPC;
        }

        /// <summary>
        /// 查询箱号库存，数据来源：仓位库存表
        /// </summary>
        /// <param name="strXHTM">箱号条码</param>
        /// <returns></returns>
        public static decimal GetXHKC(string strXHTM)
        {
            object kc = DataClass.GetValue("select 数量 from 仓位库存表  with(nolock)  where 箱号条码='" + strXHTM + "'");
            if(kc==null)
                return 0;
            decimal nKC = (decimal)kc;
            return nKC;
        }

        /// <summary>
        /// 查询箱号条码对应的仓位号，数据来源：仓位库存表
        /// </summary>
        /// <param name="strXHTM">箱号条码</param>
        /// <returns></returns>
        public static string GetCWH(string strXHTM)
        {
            string strCWH = (string)DataClass.GetValue("select cwh from 仓位库存表  with(nolock)  where 箱号条码='" + strXHTM + "'");
            if (strCWH == null)
                strCWH = "";
            return strCWH;
        }

        /// <summary>
        /// 检查半成品箱号条码
        /// </summary>
        /// <param name="strXHTM">箱号条码</param>
        /// <returns></returns>
        public static bool CheckBcpXHTM(string strXHTM)
        {
            string selectcmd = "if exists(select * from 半成品条码表  with(nolock)  where 箱号条码='" + strXHTM + "')";
            selectcmd += "\n    select 1";
            selectcmd += "\n else";
            selectcmd += "\n    select 0";

            if ((int)DataClass.GetValue(selectcmd) == 1)
                return true;
            else
                return false;
        }
    }
}
