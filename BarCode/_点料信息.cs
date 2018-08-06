using System;
using System.Collections.Generic;
using System.Text;

namespace BarCode
{
    public class _点料信息
    {
        /// <summary>
        /// 箱号条码
        /// </summary>
        private string xhtm;
        /// <summary>
        /// 来料批次
        /// </summary>
        private string llpc;
        /// <summary>
        /// 材料编号
        /// </summary>
        private string clbh;
        /// <summary>
        /// 数量
        /// </summary>
        private decimal sl = 0.00M;
        /// <summary>
        /// 是否已清点
        /// </summary>
        private bool _已清点 = false;
        /// <summary>
        /// 是否已处理
        /// </summary>
        private bool _已处理 = false;
        /// <summary>
        /// 退料单号
        /// </summary>
        private string tldh;

        /// <summary>
        /// 材料编号
        /// </summary>
        public string 材料编号
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.clbh;
            }
            set
            {
                this.clbh = value;
            }
        }

        /// <summary>
        /// 来料批次
        /// </summary>
        public string 来料批次
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.llpc;
            }
            set
            {
                this.llpc = value;
            }
        }

        /// <summary>
        /// 数量
        /// </summary>
        public decimal 数量
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.sl;
            }
            set
            {
                this.sl = value;
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
        /// 是否已清点
        /// </summary>
        public bool 已清点
        {
            get
            {
                //throw new System.NotImplementedException();
                return this._已清点;
            }
            set
            {
                this._已清点 = value;
            }
        }

        /// <summary>
        /// 是否已处理
        /// </summary>
        public bool 已处理
        {
            get
            {
                //throw new System.NotImplementedException();
                return this._已处理;
            }
            set
            {
                this._已处理 = value;
            }
        }

        /// <summary>
        /// 退料单号
        /// </summary>
        public string 退料单号
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.tldh;
            }
            set
            {
                this.tldh = value;
            }
        }
    }
}
