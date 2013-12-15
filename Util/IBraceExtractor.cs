﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.Text;

namespace Winterdom.Viasfora.Util {
  public interface IBraceExtractor {
    IEnumerable<CharPos> Extract(ITextChars text);
  }
}
