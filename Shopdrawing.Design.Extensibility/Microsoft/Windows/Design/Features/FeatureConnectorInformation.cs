﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Windows.Design.Features.FeatureConnectorInformation
// Assembly: Microsoft.Windows.Design.Extensibility, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 4673B7C2-4EF5-4715-85F2-D8E573468337
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Windows.Design.Extensibility\Microsoft.Windows.Design.Extensibility.dll

using System;
using System.Collections.Generic;

namespace Microsoft.Windows.Design.Features
{
  public abstract class FeatureConnectorInformation
  {
    public abstract Type FeatureConnectorType { get; }

    public abstract IEnumerable<Type> RequiredServices { get; }

    public abstract IEnumerable<Type> RequiredItems { get; }

    public abstract IEnumerable<Type> PendingServices { get; }

    public abstract IEnumerable<Type> PendingItems { get; }
  }
}
