using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BarCode
{
    public class _批次信息集合:KeyedCollection<string,_批次信息>
    {
        protected override string GetKeyForItem(_批次信息 item)
        {
            //throw new NotImplementedException();
            return item.来料批次;
        }
    }
}
