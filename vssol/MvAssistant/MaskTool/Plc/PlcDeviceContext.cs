﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvAssistant.MaskTool.Plc
{
    public class PlcDeviceContext
    {


        public T Read<T>(EnumPlcVariable plcvar)
        {
            throw new NotImplementedException();
        }
        public void Write(EnumPlcVariable plcvar, object data)
        {
            throw new NotImplementedException();
        }

    }
}
