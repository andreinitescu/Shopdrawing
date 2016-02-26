﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Expression.DesignSurface.Import.IImporterContext
// Assembly: Microsoft.Expression.DesignSurface, Version=4.0.20525.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// MVID: 59645F1A-1518-4EC7-B4B6-3D42DEC6EBA3
// Assembly location: C:\Program Files (x86)\Microsoft Expression\Blend 4\Microsoft.Expression.DesignSurface.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Versioning;
using System.Windows;
using System.Windows.Media;

namespace Microsoft.Expression.DesignSurface.Import
{
  public interface IImporterContext
  {
    string ImportFilePath { get; }

    string TemporaryFolder { get; }

    string TargetImportPath { get; }

    IDictionary<string, object> HostData { get; }

    FrameworkName HostPlatform { get; }

    bool NoUserInterface { get; }

    string AddSupportingFileToProject(string fileName, out string sourceReference, bool useExistingFile);

    void ExecuteAsyncImport(Action<object, DoWorkEventArgs> handler, object argument);

    string FindFont(string fontNameToken, string modifierToken);

    void LogMessage(string message);

    MessageBoxResult PromptUserYesNo(string message, string yesText, string noText, string automationId);

    void UpdateProgress(double ratio);

    void SimplifyPathData(ref System.Windows.Media.Geometry geometry);
  }
}
