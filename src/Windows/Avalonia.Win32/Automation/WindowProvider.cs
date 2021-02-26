﻿using Avalonia.Controls.Automation.Peers;

#nullable enable

namespace Avalonia.Win32.Automation
{
    internal class WindowProvider : WindowBaseProvider
    {
        public WindowProvider(WindowAutomationPeer peer)
            : base(peer)
        {
        }
    }
}