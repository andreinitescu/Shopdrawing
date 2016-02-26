﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.Code.Classifiers.XamlTokenizerContext
// Assembly: Microsoft.Expression.Code, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 3445693A-E9B1-4B68-8C1A-000C20F2A3F8
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.Code.dll

using System;

namespace Microsoft.Expression.Code.Classifiers
{
  public struct XamlTokenizerContext : IComparable<XamlTokenizerContext>
  {
    public XamlTokenizerState State { get; set; }

    internal int ScannerState { get; set; }

    public int CompareTo(XamlTokenizerContext other)
    {
      int num = ((int) this.State).CompareTo((int) other.State);
      if (num == 0)
        return this.ScannerState.CompareTo(other.ScannerState);
      return num;
    }

    public override string ToString()
    {
      return this.State.ToString() + ", " + this.ScannerState.ToString();
    }
  }
}
