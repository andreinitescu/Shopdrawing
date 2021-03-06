﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.DesignSurface.ViewModel.PrimitiveShapeElement
// Assembly: Microsoft.Expression.DesignSurface, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 59645F1A-1518-4EC7-B4B6-3D42DEC6EBA3
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.DesignSurface.dll

using Microsoft.Expression.DesignModel.Metadata;

namespace Microsoft.Expression.DesignSurface.ViewModel
{
  public class PrimitiveShapeElement : ShapeElement
  {
    public static readonly IPropertyId RenderedGeometryProperty = (IPropertyId) ProjectNeutralTypes.PrimitiveShape.GetMember(MemberType.LocalProperty, "RenderedGeometry", MemberAccessTypes.Public);
    public new static readonly SceneNode.ConcreteSceneNodeFactory Factory = (SceneNode.ConcreteSceneNodeFactory) new PrimitiveShapeElement.PrimitiveShapeElementFactory();

    private class PrimitiveShapeElementFactory : SceneNode.ConcreteSceneNodeFactory
    {
      protected override SceneNode Instantiate()
      {
        return (SceneNode) new PrimitiveShapeElement();
      }
    }
  }
}
