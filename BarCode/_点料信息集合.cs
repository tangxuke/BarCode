﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BarCode
{
    public class _点料信息集合:KeyedCollection<string,_点料信息>
    {
        protected override string GetKeyForItem(_点料信息 item)
        {
            //throw new NotImplementedException();
            return item.箱号条码;
        }
    }
}
