using System;
using System.Collections.Generic;
using System.Text;

namespace BarCode
{
    public class _发料单信息
    {
        /// <summary>
        /// 配料单号
        /// </summary>
        private string pldno;
        /// <summary>
        /// 产品编号
        /// </summary>
        private string cpbh;
        /// <summary>
        /// 开拉号
        /// </summary>
        private string klh;

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
        /// 产品编号
        /// </summary>
        public string 产品编号
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.cpbh;
            }
            set
            {
                this.cpbh = value;
            }
        }

        /// <summary>
        /// 开拉号
        /// </summary>
        public string 开拉号
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.klh;
            }
            set
            {
                this.klh = value;
            }
        }
    }
}
