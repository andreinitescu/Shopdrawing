﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.DesignSurface.View.ActualSizeCommand
// Assembly: Microsoft.Expression.DesignSurface, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 59645F1A-1518-4EC7-B4B6-3D42DEC6EBA3
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.DesignSurface.dll

namespace Microsoft.Expression.DesignSurface.View
{
  internal sealed class ActualSizeCommand : SceneViewDesignCommand
  {
    public override bool IsEnabled
    {
      get
      {
        if (base.IsEnabled)
          return this.SceneView.Zoom != 1.0;
        return false;
      }
    }

    public ActualSizeCommand(SceneView sceneView)
      : base(sceneView)
    {
    }

    public override void Execute()
    {
      this.SceneView.Zoom = 1.0;
    }
  }
}
