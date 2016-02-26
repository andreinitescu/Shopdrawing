﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.Utility.Interop.SafeModuleHandle
// Assembly: Microsoft.Expression.Utility, Version=5.0.30709.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: B77F0E80-A3D7-4861-BF76-6A6A586443F3
// Assembly location: C:\Users\M4600\Documents\Project\4.5\Microsoft.Expression.ProjectReferences\Microsoft.Expression.Utility.dll

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Expression.Utility.Interop
{
  public class SafeModuleHandle : SafeHandle
  {
    public override bool IsInvalid
    {
      get
      {
        return this.handle == IntPtr.Zero;
      }
    }

    public SafeModuleHandle()
      : base(IntPtr.Zero, true)
    {
    }

    protected override bool ReleaseHandle()
    {
      if (this.IsClosed)
        return true;
      return NativeMethods.FreeLibrary(this);
    }
  }
}
