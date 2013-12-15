﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Winterdom.Viasfora.Util {
  public interface ITextChars {
    int Position { get; }
    int AbsolutePosition { get; }
    bool EndOfLine { get; }
    char Char();
    char NChar();
    void Next();
    void Skip(int count);
    void SkipRemainder();
  }
}
