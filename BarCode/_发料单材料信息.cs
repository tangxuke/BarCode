using System;
using System.Collections.Generic;
using System.Text;

namespace BarCode
{
    public class _发料单材料信息
    {
        /// <summary>
        /// 配料单号
        /// </summary>
        private string pldno;
        /// <summary>
        /// 材料编号
        /// </summary>
        private string clbh;
        /// <summary>
        /// 余欠数
        /// </summary>
        private decimal yqs = 0.00M;

        /// <summary>
        /// 配料单号
        /// </summary>
        public string 单号
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.pldno;
            }
            set
            {
                this.pldno = value;
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
        /// 余欠数
        /// </summary>
        public decimal 余欠数
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.yqs;
            }
            set
            {
                this.yqs = value;
            }
        }
    }
}
