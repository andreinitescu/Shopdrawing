﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.DesignSurface.Documents.SceneDocumentType
// Assembly: Microsoft.Expression.DesignSurface, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 59645F1A-1518-4EC7-B4B6-3D42DEC6EBA3
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.DesignSurface.dll

using Microsoft.Expression.DesignSurface;

namespace Microsoft.Expression.DesignSurface.Documents
{
  internal sealed class SceneDocumentType : XamlDocumentType
  {
    private const string BuildTask = "Page";

    public override string Name
    {
      get
      {
        return "XAML";
      }
    }

    public override string Description
    {
      get
      {
        return StringTable.SceneDocumentTypeDescription;
      }
    }

    protected override string FileNameBase
    {
      get
      {
        return "UserControl";
      }
    }

    protected override string DefaultBuildTask
    {
      get
      {
        return "Page";
      }
    }

    public SceneDocumentType(DesignerContext designerContext)
      : base(designerContext)
    {
    }
  }
}
