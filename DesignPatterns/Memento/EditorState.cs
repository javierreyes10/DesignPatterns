using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    //memento
    public class EditorState
    {
        public string Contet { get; set; }
        public string FontName { get; set; }
        public string FontSize { get; set; }

        public EditorState(string contet, string fontName, string fontSize)
        {
            Contet = contet;
            FontName = fontName;
            FontSize = fontSize;
        }
    }
}
