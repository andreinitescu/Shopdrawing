﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.Framework.Data.LocalizableSwitchCase
// Assembly: Microsoft.Expression.Framework, Version=4.0.1000.1000, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 1CFB9CAE-EE8F-44DB-B6AB-EAABBC8A4B40
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.Framework.dll

using System.Windows;

namespace Microsoft.Expression.Framework.Data
{
  public class LocalizableSwitchCase : DependencyObject
  {
    private static readonly DependencyProperty InProperty = DependencyProperty.Register("In", typeof (object), typeof (LocalizableSwitchCase));
    private static readonly DependencyProperty OutProperty = DependencyProperty.Register("Out", typeof (string), typeof (LocalizableSwitchCase));

    public object In
    {
      get
      {
        return this.GetValue(LocalizableSwitchCase.InProperty);
      }
      set
      {
        this.SetValue(LocalizableSwitchCase.InProperty, value);
      }
    }

    [Localizability(LocalizationCategory.Text, Modifiability = Modifiability.Modifiable, Readability = Readability.Readable)]
    public string Out
    {
      get
      {
        return (string) this.GetValue(LocalizableSwitchCase.OutProperty);
      }
      set
      {
        this.SetValue(LocalizableSwitchCase.OutProperty, (object) value);
      }
    }
  }
}
