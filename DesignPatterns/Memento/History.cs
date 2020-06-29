using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    //CareTaker
    public class History
    {
        private readonly Stack<EditorState> _editorStates;

        public History()
        {
            _editorStates = new Stack<EditorState>();
        }

        public void Backup(EditorState editorState)
        {
            _editorStates.Push(editorState);
        }

        public EditorState Undo()
        {
            return _editorStates.Pop();
        }
    }
}
