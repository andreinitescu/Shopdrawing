﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.DesignSurface.Annotations.Commands.AnnotationsCommand
// Assembly: Microsoft.Expression.DesignSurface, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 59645F1A-1518-4EC7-B4B6-3D42DEC6EBA3
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.DesignSurface.dll

using Microsoft.Expression.DesignSurface.Annotations;
using Microsoft.Expression.DesignSurface.View;
using Microsoft.Expression.DesignSurface.ViewModel;
using System.Collections.Generic;

namespace Microsoft.Expression.DesignSurface.Annotations.Commands
{
  internal abstract class AnnotationsCommand : SceneViewDesignCommand
  {
    public override bool IsEnabled
    {
      get
      {
        if (base.IsEnabled)
          return this.AnnotationService.AnnotationsEnabled;
        return false;
      }
    }

    internal AnnotationService AnnotationService
    {
      get
      {
        return this.SceneView.DesignerContext.AnnotationService;
      }
    }

    internal IEnumerable<AnnotationSceneNode> Annotations
    {
      get
      {
        return this.SceneView.ViewModel.AnnotationEditor.Annotations;
      }
    }

    protected AnnotationsCommand(SceneView view)
      : base(view)
    {
    }
  }
}
