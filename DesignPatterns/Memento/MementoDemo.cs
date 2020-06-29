using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    public class MementoDemo
    {
        public static void Demo()
        {
            var editor = new Editor("Javier", "Calibri A", "12 A");
            var history = new History();

            history.Backup(editor.CreateBackup());

            editor.Contet = "Javier Antonio";
            editor.FontSize = "20 B";
            editor.FontName = "Arial Black B";

            history.Backup(editor.CreateBackup());

            editor.Contet = "Javier Antonio Reyes";
            editor.FontSize = "30 C";
            editor.FontName = "Times New Roman C";

            Console.WriteLine(editor.ToString());

            editor.Restore(history.Undo());

            Console.WriteLine(editor.ToString());

            editor.Restore(history.Undo());

            Console.WriteLine(editor.ToString());
        }
    }
}
