using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static MGShaderEditor.Game1;

namespace MGShaderEditor.Persistence
{
    public class ConfigData
    {
        public int RecWidth = 640;
        public int RecHeight = 480;
        public String LastOpenendPath = "";
        internal string TexturePath;
        public RenderMode RenderMode;
    }
}
