using System;

namespace LazyCoder.Writer
{
    public interface IKeyboard
    {
        IKeyboard Type(params string[] words);
        IKeyboard Write<T>(T tsThing);
        IDisposable Line();
        IDisposable Block();
        IKeyboard NewLine();
        IKeyboard Indent();
    }
}