﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    interface IMyInterface : IParentInterface
    {
        void MethodToImplement();
    }

    interface IParentInterface
    {
        void ParentInterfaceMethod();
    }
}
