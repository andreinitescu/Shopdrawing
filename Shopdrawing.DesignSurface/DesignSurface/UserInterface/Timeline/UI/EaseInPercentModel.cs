﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.DesignSurface.UserInterface.Timeline.UI.EaseInPercentModel
// Assembly: Microsoft.Expression.DesignSurface, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 59645F1A-1518-4EC7-B4B6-3D42DEC6EBA3
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.DesignSurface.dll

namespace Microsoft.Expression.DesignSurface.UserInterface.Timeline.UI
{
  public class EaseInPercentModel : EasePercentModel
  {
    public override bool IsSelected
    {
      get
      {
        return this.TimelineView.EaseInSelectedKeyFrames == this.Percent;
      }
      set
      {
        this.TimelineView.EaseInSelectedKeyFrames = this.Percent;
      }
    }

    internal EaseInPercentModel(TimelineView timelineView, double percent)
      : base(timelineView, percent)
    {
    }
  }
}
