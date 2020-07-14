﻿using System.Collections.Generic;
using LanguageExt;

namespace Disambiguation {
  class Sandbox {
    public Option<int> Method() =>
      new Dictionary<int, int>()
        .As<IDictionary<int, int>>()
        .TryGetValue(0);
  }
}
