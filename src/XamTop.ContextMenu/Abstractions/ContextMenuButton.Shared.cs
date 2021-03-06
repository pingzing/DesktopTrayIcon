﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XamTop.ContextMenu.Abstractions
{
    public class ContextMenuButton : IContextMenuButton
    {
        public string Label { get; set; }
        public EventHandler Clicked { get; set; }
    }
}
