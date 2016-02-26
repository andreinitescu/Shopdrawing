﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.Code.Actipro.SelectAllCommand
// Assembly: Microsoft.Expression.Code, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 3445693A-E9B1-4B68-8C1A-000C20F2A3F8
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.Code.dll

namespace Microsoft.Expression.Code.Actipro
{
  internal class SelectAllCommand : ActiproCommand
  {
    public override bool IsEnabled
    {
      get
      {
        if (base.IsEnabled)
          return this.View.Selection.Length != this.Editor.Document.Length;
        return false;
      }
    }

    public SelectAllCommand(ActiproEditor editor)
      : base(editor)
    {
    }

    public override void Execute()
    {
      this.View.Selection.SelectAll();
      base.Execute();
    }
  }
}
