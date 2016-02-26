﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Windows.Design.Policies.PrimarySelectionPolicy
// Assembly: Microsoft.Windows.Design.Interaction, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 6B798143-45D7-48F3-B5E1-F76B9E61E2E6
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Windows.Design.Interaction\Microsoft.Windows.Design.Interaction.dll

using Microsoft.Windows.Design.Interaction;
using Microsoft.Windows.Design.Model;
using System.Collections.Generic;

namespace Microsoft.Windows.Design.Policies
{
  public class PrimarySelectionPolicy : SelectionPolicy
  {
    protected override IEnumerable<ModelItem> GetPolicyItems(Selection selection)
    {
      ModelItem primarySelection = selection.PrimarySelection;
      if (primarySelection == null)
        return (IEnumerable<ModelItem>) new ModelItem[0];
      return (IEnumerable<ModelItem>) new ModelItem[1]
      {
        primarySelection
      };
    }
  }
}
