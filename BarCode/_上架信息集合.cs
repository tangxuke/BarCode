using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Data;

namespace BarCode
{
    public class _上架信息集合:KeyedCollection<string,_上架信息>
    {
        protected override string GetKeyForItem(_上架信息 item)
        {
            //throw new NotImplementedException();
            return item.箱号条码;
        }

        /// <summary>
        /// 从数据表加载
        /// </summary>
        /// <param name="table">数据表</param>
        public void FromDataTable(DataTable table)
        {
            //throw new System.NotImplementedException();
            if (table.Rows.Count == 0)
                return;
            foreach (DataRow row in table.Rows)
            {
                _上架信息 obj = _上架信息.FromDataRow(row);
                if(!this.Contains(obj))
                    this.Add(obj);
            }
        }
    }
}
