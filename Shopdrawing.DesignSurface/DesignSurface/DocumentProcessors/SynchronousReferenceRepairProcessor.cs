﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.DesignSurface.DocumentProcessors.SynchronousReferenceRepairProcessor
// Assembly: Microsoft.Expression.DesignSurface, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 59645F1A-1518-4EC7-B4B6-3D42DEC6EBA3
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.DesignSurface.dll

using Microsoft.Expression.DesignSurface;
using Microsoft.Expression.Framework;

namespace Microsoft.Expression.DesignSurface.DocumentProcessors
{
  internal sealed class SynchronousReferenceRepairProcessor : ReferenceRepairProcessor
  {
    public SynchronousReferenceRepairProcessor(DesignerContext designerContext, ReferenceChangeModel referenceChangeModel)
      : base(designerContext, referenceChangeModel, (IAsyncMechanism) new SynchronousAsyncMechanism())
    {
    }
  }
}
