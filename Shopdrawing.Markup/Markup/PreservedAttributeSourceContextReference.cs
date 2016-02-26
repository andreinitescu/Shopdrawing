﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.DesignModel.Markup.PreservedAttributeSourceContextReference
// Assembly: Microsoft.Expression.Markup, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: C29AFBAF-B4D4-48F4-95E5-A72FADF351FB
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.Markup.dll

using Microsoft.Expression.DesignModel.DocumentModel;

namespace Microsoft.Expression.DesignModel.Markup
{
  internal sealed class PreservedAttributeSourceContextReference : SourceContextReference
  {
    private XmlElementReference.Attribute attribute;

    public override XamlSourceContext SourceContext
    {
      get
      {
        return this.attribute.SourceContext;
      }
      set
      {
        this.attribute.SourceContext = value;
      }
    }

    public PreservedAttributeSourceContextReference(XmlElementReference.Attribute attribute)
      : base((DocumentNode) null)
    {
      this.attribute = attribute;
    }

    public override XmlAttributeReference BuildXmlAttributeReference()
    {
      XmlAttributeReference attributeReference = base.BuildXmlAttributeReference();
      if (this.attribute.SourceContext != null)
        attributeReference.Parent = this.attribute.SourceContext.Parent;
      return attributeReference;
    }
  }
}
