using System;
using System.Collections.Generic;
using System.Linq;

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        if (!_isHidden)
        {
            _text = new string('_', _text.Length);
            _isHidden = true;
        }
    }

    public void Show()
    {
        if (_isHidden)
        {
            _text = _text.Replace('_', 'a');
            _isHidden = false;
        }
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}
