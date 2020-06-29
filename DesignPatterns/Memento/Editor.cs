using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    //Originator
    public class Editor
    {
        public string Contet { get; set; }
        public string FontName { get; set; }
        public string FontSize { get; set; }

        public Editor(string contet, string fontName, string fontSize)
        {
            Contet = contet;
            FontName = fontName;
            FontSize = fontSize;
        }

        public EditorState CreateBackup()
        {
            return new EditorState(Contet, FontName, FontSize);
        }

        public void Restore(EditorState editorState)
        {
            Contet = editorState.Contet;
            FontName = editorState.FontName;
            FontSize = editorState.FontSize;
        }

        public override string ToString()
        {
            return $"Content: {Contet} FontName: {FontName} FontSize {FontSize}";
        }
    }
}
