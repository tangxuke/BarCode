using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BarCode
{
    public class _上架信息
    {
        /// <summary>
        /// cwh
        /// </summary>
        private string cwh;
        /// <summary>
        /// 箱号条码
        /// </summary>
        private string xhtm;
        /// <summary>
        /// 上架否
        /// </summary>
        private bool sjf=false;
        /// <summary>
        /// 状态
        /// </summary>
        private string state;
        /// <summary>
        /// 处理否
        /// </summary>
        private bool dealed = false;
        /// <summary>
        /// 上架类型
        /// </summary>
        private _上架类型 type;

        /// <summary>
        /// 处理否
        /// </summary>
        public bool 处理否
        {
            get
            {
                return this.dealed;
            }
            set
            {
                this.dealed = value;
            }
        }

        /// <summary>
        /// cwh
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
        /// 上架否
        /// </summary>
        public bool 上架否
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.sjf;
            }
            set
            {
                this.sjf = value;
            }
        }

        /// <summary>
        /// 状态（良品，不良品）
        /// </summary>
        public string 状态
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }

        /// <summary>
        /// 上架类型
        /// </summary>
        public _上架类型 上架类型
        {
            get
            {
                //throw new System.NotImplementedException();
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        /// <summary>
        /// 从数据行加载
        /// </summary>
        /// <param name="row">数据行</param>
        public static BarCode._上架信息 FromDataRow(DataRow row)
        {
            //throw new System.NotImplementedException();
            _上架信息 obj = new _上架信息();
            obj.箱号条码 = row["箱号条码"].ToString();
            obj.状态 = row["状态"].ToString();
            switch (row["类型"].ToString())
            {
                case "来料":
                    obj.上架类型 = _上架类型.来料;
                    break;
                case "退料":
                    obj.上架类型 = _上架类型.退料;
                    break;
                case "复检":
                    obj.上架类型 = _上架类型.复检;
                    break;
                case "发料取消":
                    obj.上架类型 = _上架类型.发料取消;
                    break;
                case "配料取消":
                    obj.上架类型 = _上架类型.配料取消;
                    break;
                case "初始化":
                    obj.上架类型 = _上架类型.初始化;
                    break;
            }
            return obj;
        }
    }
}
