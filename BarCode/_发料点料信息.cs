using System;
using System.Collections.Generic;
using System.Text;

namespace BarCode
{
    public class _发料点料信息
    {
        /// <summary>
        /// 单号
        /// </summary>
        private string dh;
        /// <summary>
        /// 箱号条码
        /// </summary>
        private string xhtm;
        /// <summary>
        /// 已点料
        /// </summary>
        private bool ydl = false;
        /// <summary>
        /// 已更新
        /// </summary>
        private bool isUpdate;

        /// <summary>
        /// 单号
        /// </summary>
        public string 单号
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.dh;
            }
            set
            {
                this.dh = value;
            }
        }

        /// <summary>
        /// 箱号条码
        /// </summary>
        public string 箱号条码
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.xhtm;
            }
            set
            {
                this.xhtm = value;
            }
        }

        /// <summary>
        /// 已点料
        /// </summary>
        public bool 已点料
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.ydl;
            }
            set
            {
                this.ydl = value;
            }
        }

        /// <summary>
        /// 已更新
        /// </summary>
        public bool 已更新
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.isUpdate;
            }
            set
            {
                this.isUpdate = value;
            }
        }
    }
}
