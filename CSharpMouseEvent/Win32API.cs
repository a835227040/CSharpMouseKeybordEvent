using System;
using System.Runtime.InteropServices;

namespace CSharpMouseKeybordEvent.Win32API
{
    /// <summary>
    /// 对win32api的静态封装
    /// </summary>
    internal static class Win32API
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);
        [DllImport("user32.dll")]
        static extern void mouse_event(MouseEventFlag flags, int dx, int dy, uint data, UIntPtr extraInfo);
        
    }
}
