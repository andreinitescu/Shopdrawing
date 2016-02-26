﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.DesignSurface.UserInterface.Timeline.EmptyTimelineItem
// Assembly: Microsoft.Expression.DesignSurface, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 59645F1A-1518-4EC7-B4B6-3D42DEC6EBA3
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.DesignSurface.dll

using Microsoft.Expression.DesignSurface.UserInterface.Timeline.UI;

namespace Microsoft.Expression.DesignSurface.UserInterface.Timeline
{
  internal class EmptyTimelineItem
  {
    private TimelinePane timelinePane;

    public string DisplayName
    {
      get
      {
        return string.Empty;
      }
      set
      {
      }
    }

    public bool IsActive
    {
      get
      {
        return false;
      }
    }

    public TimelinePane TimelinePane
    {
      get
      {
        return this.timelinePane;
      }
    }

    public EmptyTimelineItem(TimelinePane timelinePane)
    {
      this.timelinePane = timelinePane;
    }
  }
}
