using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    //CareTaker
    public class History
    {
        private readonly Stack<EditorState> _editorStates;
        private readonly Editor _editor;

        public History(Editor editor)
        {
            _editor = editor;
            _editorStates = new Stack<EditorState>();
        }

        public void Backup()
        {
            _editorStates.Push(_editor.CreateBackup());
        }

        public void Undo()
        {
            _editor.Restore(_editorStates.Pop());
        }
    }
}
