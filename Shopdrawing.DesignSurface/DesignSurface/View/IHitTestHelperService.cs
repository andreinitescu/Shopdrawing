﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.DesignSurface.View.IHitTestHelperService
// Assembly: Microsoft.Expression.DesignSurface, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 59645F1A-1518-4EC7-B4B6-3D42DEC6EBA3
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.DesignSurface.dll

using Microsoft.Expression.DesignModel.ViewObjects;
using Microsoft.Expression.DesignSurface.ViewModel;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace Microsoft.Expression.DesignSurface.View
{
  public interface IHitTestHelperService
  {
    SceneView SceneView { get; }

    IList<SceneElement> HitElements { get; }

    IntersectionDetail HitTestBounds(Rect bounds, IViewVisual element);

    IViewObject QueryHitTestModifier(IViewObject hitVisual);
  }
}
