﻿/*
* PROJECT:          Aura Operating System Development
* CONTENT:          Consoles
* PROGRAMMERS:      Valentin Charbonnier <valentinbreiz@gmail.com>
*/

using System;
using Aura_OS.System.Shell.VBE.CosmosGLGraphics;
using IL2CPU.API.Attribs;

namespace Aura_OS.System.Shell
{

    [Plug(Target = typeof(Cosmos.System.Console))]
    public abstract class Console
    {

        public Console()
        {

        }

        public string Name;

        public abstract int X { get; set; }
        public abstract int Y { get; set; }

        public abstract int Width { get; }
        public abstract int Height { get; }

        public abstract int Cols { get; }
        public abstract int Rows { get; }

        public abstract void Clear();

        public abstract void Write(byte[] aText);

        public abstract ConsoleColor Foreground { get; set; }

        public abstract ConsoleColor Background { get; set; }

        public abstract int CursorSize { get; set; }

        public abstract bool CursorVisible { get; set; }

        public abstract void DrawImage(ushort X, ushort Y, ushort Length, ushort height, Image image);

        public abstract void DisableGraphicMode();

    }

    public static class ConsoleMode
    {

        public enum Mode1152x864
        {
            Rows = 127,
            Cols = 54
        };

        public enum Mode1280x768
        {
            Rows = 138,
            Cols = 48
        };

        public enum Mode1360x768
        {
            Rows = 149, //+1?
            Cols = 48
        };

        public enum Mode1366x768
        {
            Rows = 150,
            Cols = 48
        };

        public enum Mode1600x1200
        {
            Rows = 176,
            Cols = 75
        };

        public enum Mode1920x1080
        {
            Rows = 141, // Not good value
            Cols = 48 // Not good value
        };

    }
}
