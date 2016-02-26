﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.DesignSurface.Tools.DataBindingDragDropFlags
// Assembly: Microsoft.Expression.DesignSurface, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 59645F1A-1518-4EC7-B4B6-3D42DEC6EBA3
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.DesignSurface.dll

using System;

namespace Microsoft.Expression.DesignSurface.Tools
{
  [Flags]
  public enum DataBindingDragDropFlags
  {
    None = 0,
    SetBinding = 1,
    CreateElement = 2,
    AutoPickProperty = 4,
    DiscourageDataContext = 8,
    AllowRetargetElement = 16,
    ObjectTreeDefault = AutoPickProperty | CreateElement | SetBinding,
    ArtboardDefault = ObjectTreeDefault | AllowRetargetElement,
  }
}
