﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesPattCode.MementoWithCommandProcessor.Framework
{
    // Command objektumok közös interfésze.
    // Egy új parancs bevezetésekor implementálni kell:
    // meg kell írni az Execute műveletben a parancs
    // specifikus logikát, az UnExecute műveletben pedig a 
    // parancs visszavonását.
    public interface ICommand
    {
        void Execute();
        void UnExecute();
    }
}