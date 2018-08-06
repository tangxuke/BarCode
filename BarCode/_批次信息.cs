using System;
using System.Collections.Generic;
using System.Text;

namespace BarCode
{
    public class _批次信息
    {
        /// <summary>
        /// 来料批次
        /// </summary>
        private string llpc;
        /// <summary>
        /// 库存数量
        /// </summary>
        private decimal kcsl = 0.00M;
        /// <summary>
        /// 已发数量
        /// </summary>
        private decimal yfsl = 0.00M;
        /// <summary>
        /// 冻结数量
        /// </summary>
        private decimal djsl = 0.00M;
        /// <summary>
        /// 材料编号
        /// </summary>
        private string clbh;

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
        /// 库存数量
        /// </summary>
        public decimal 库存数量
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.kcsl;
            }
            set
            {
                this.kcsl = value;
            }
        }

        /// <summary>
        /// 已发数量
        /// </summary>
        public decimal 已发数量
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.yfsl;
            }
            set
            {
                this.yfsl = value;
            }
        }

        /// <summary>
        /// 冻结数量
        /// </summary>
        public decimal 冻结数量
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.djsl;
            }
            set
            {
                this.djsl = value;
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
    }
}
