﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BarCode
{
    public class _发料单材料信息集合:KeyedCollection<string,_发料单材料信息>
    {
        protected override string GetKeyForItem(_发料单材料信息 item)
        {
            //throw new NotImplementedException();
            return item.材料编号;
        }
    }
}
