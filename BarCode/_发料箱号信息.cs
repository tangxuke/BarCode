using System;
using System.Collections.Generic;
using System.Text;

namespace BarCode
{
    public class _发料箱号信息
    {
        /// <summary>
        /// 仓位号
        /// </summary>
        private string cwh;
        /// <summary>
        /// 箱号条码
        /// </summary>
        private string xhtm;
        /// <summary>
        /// 材料编号
        /// </summary>
        private string clbh;
        /// <summary>
        /// 来料批次
        /// </summary>
        private string llpc;
        /// <summary>
        /// 数量
        /// </summary>
        private decimal sl = 0.00M;
        /// <summary>
        /// 已发料
        /// </summary>
        private bool yfl = false;
        /// <summary>
        /// 已上传
        /// </summary>
        private bool ysc = false;
        /// <summary>
        /// 单号
        /// </summary>
        private string dh;

        /// <summary>
        /// 仓位号
        /// </summary>
        public string 仓位号
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.cwh;
            }
            set
            {
                this.cwh = value;
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
        /// 已发料
        /// </summary>
        public bool 已发料
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.yfl;
            }
            set
            {
                this.yfl = value;
            }
        }

        /// <summary>
        /// 已上传
        /// </summary>
        public bool 已上传
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.ysc;
            }
            set
            {
                this.ysc = value;
            }
        }

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
    }
}
