﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.DesignSurface.UserInterface.PropertyInspector.TransformEditor.RotationAngleToRotateTransformConverter
// Assembly: Microsoft.Expression.DesignSurface, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 59645F1A-1518-4EC7-B4B6-3D42DEC6EBA3
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.DesignSurface.dll

using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Microsoft.Expression.DesignSurface.UserInterface.PropertyInspector.TransformEditor
{
  public sealed class RotationAngleToRotateTransformConverter : IValueConverter
  {
    public object Convert(object o, Type targetType, object parameter, CultureInfo culture)
    {
      return (object) new RotateTransform((double) o);
    }

    public object ConvertBack(object o, Type targetType, object parameter, CultureInfo culture)
    {
      return (object) null;
    }
  }
}
