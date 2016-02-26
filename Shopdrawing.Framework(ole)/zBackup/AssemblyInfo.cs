﻿using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows;

//[assembly: AssemblyTitle("Shopdrawing.Framework")]
//[assembly: AssemblyDescription("")]
//[assembly: AssemblyConfiguration("")]
//[assembly: AssemblyCompany("Microsoft")]
//[assembly: AssemblyProduct("Shopdrawing.Framework")]
//[assembly: AssemblyCopyright("Copyright © Microsoft 2015")]
//[assembly: AssemblyTrademark("")]
//[assembly: AssemblyCulture("")]

[assembly: InternalsVisibleTo("Microsoft.Expression.Web.Performance.UnitTests, PublicKey=002400000480000094000000060200000024000052534131000400000100010037C9D8EFD6274C6361E67293773C01C891EE2C92DA37F778F0B7FCDF0885382810628F813ECC3E0B2E29CDE06DFB8082A8841B6EDDAA739F572B8D137BDC85D143AAA08776EAB7DDB32F6B0CE4717A1446EB5E135E0C3E2F94FF87FC93EA2B21743F52E48E88591640EDB71C0C832892542A8BCDEF8FF7ED04F77DF6910AFEB9")]
[assembly: InternalsVisibleTo("Microsoft.Expression.Blend.UnitTests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100A30E8B01DFD2A6D08B877C01D267F10811F75546E16D9CD2987E966605CF8813F3BEB7FA048CCB69809A2EC89EB808DDC098D379F433B3565870E054BEFD906092E26E8A885104329CC502032BB88C043F9F16D9DB6A0536668F01E11AEDDCB367F3F7C62AEA0ACC04FB8B6262D001E06600B2AD6FB3154B34C77939CE5F29EC")]
[assembly: InternalsVisibleTo("Microsoft.Expression.Blend.Test.Libraries, PublicKey=0024000004800000940000000602000000240000525341310004000001000100A30E8B01DFD2A6D08B877C01D267F10811F75546E16D9CD2987E966605CF8813F3BEB7FA048CCB69809A2EC89EB808DDC098D379F433B3565870E054BEFD906092E26E8A885104329CC502032BB88C043F9F16D9DB6A0536668F01E11AEDDCB367F3F7C62AEA0ACC04FB8B6262D001E06600B2AD6FB3154B34C77939CE5F29EC")]
[assembly: InternalsVisibleTo("Microsoft.Expression.EditorHost.UnitTests, PublicKey=002400000480000094000000060200000024000052534131000400000100010037C9D8EFD6274C6361E67293773C01C891EE2C92DA37F778F0B7FCDF0885382810628F813ECC3E0B2E29CDE06DFB8082A8841B6EDDAA739F572B8D137BDC85D143AAA08776EAB7DDB32F6B0CE4717A1446EB5E135E0C3E2F94FF87FC93EA2B21743F52E48E88591640EDB71C0C832892542A8BCDEF8FF7ED04F77DF6910AFEB9")]
//[assembly: Extension]
[assembly: Dependency("PresentationFramework", LoadHint.Always)]
[assembly: InternalsVisibleTo("Microsoft.Expression.Web.UnitTests, PublicKey=002400000480000094000000060200000024000052534131000400000100010037C9D8EFD6274C6361E67293773C01C891EE2C92DA37F778F0B7FCDF0885382810628F813ECC3E0B2E29CDE06DFB8082A8841B6EDDAA739F572B8D137BDC85D143AAA08776EAB7DDB32F6B0CE4717A1446EB5E135E0C3E2F94FF87FC93EA2B21743F52E48E88591640EDB71C0C832892542A8BCDEF8FF7ED04F77DF6910AFEB9")]
[assembly: InternalsVisibleTo("Test.Libraries, PublicKey=00240000048000009400000006020000002400005253413100040000010001007B168790E80F57E94456C976ED32ABD3487695B31A4FF13164EEFCD0D300A27931A182ADC1C4839A96125A8682DCD64B02E86AF4A4C8CC1BEAF48E2E137515E18FC0468143F999ACE47C5F61BE5E248F0F30C6E492ECC4D4321D4D2514581C7413B60850005DC9F8AAE390596591B92A8DE89DBB184BF163D92593C289F9F1CD")]
[assembly: InternalsVisibleTo("Microsoft.Expression.Framework.Workspaces.UnitTests, PublicKey=00240000048000009400000006020000002400005253413100040000010001009106b47ec8430d81d1a52156b542d5b6c62c8394abe8a9c8ce74147711bfcd8aaead33a316ce02e8bffc8ff6a1e393d39d433919a0fb99819c626205088a6bf27f54091ce8a651ccac920f6ea325b80706da9ea5a3d1865b65f35721817a9de5969ac81ce6ff65587a3d330976128e1ff117a21d45e061fbb9c9fadcea175ab2")]
[assembly: InternalsVisibleTo("Microsoft.Expression.Framework.UnitTests, PublicKey=00240000048000009400000006020000002400005253413100040000010001009106b47ec8430d81d1a52156b542d5b6c62c8394abe8a9c8ce74147711bfcd8aaead33a316ce02e8bffc8ff6a1e393d39d433919a0fb99819c626205088a6bf27f54091ce8a651ccac920f6ea325b80706da9ea5a3d1865b65f35721817a9de5969ac81ce6ff65587a3d330976128e1ff117a21d45e061fbb9c9fadcea175ab2")]
[assembly: InternalsVisibleTo("Microsoft.Expression.PrototypingEditor.UnitTests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100A30E8B01DFD2A6D08B877C01D267F10811F75546E16D9CD2987E966605CF8813F3BEB7FA048CCB69809A2EC89EB808DDC098D379F433B3565870E054BEFD906092E26E8A885104329CC502032BB88C043F9F16D9DB6A0536668F01E11AEDDCB367F3F7C62AEA0ACC04FB8B6262D001E06600B2AD6FB3154B34C77939CE5F29EC")]
[assembly: Dependency("System", LoadHint.Always)]
[assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)]
[assembly: InternalsVisibleTo("ViewManagerTests, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]
[assembly: AssemblyFileVersion("4.0.1000.1000")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyTitle("Microsoft Expression Framework")]
[assembly: AssemblyCopyright("Copyright (c) Microsoft Corporation. All rights reserved.")]
[assembly: ComVisible(false)]
[assembly: NeutralResourcesLanguage("en", UltimateResourceFallbackLocation.Satellite)]
[assembly: Dependency("WindowsBase", LoadHint.Always)]
[assembly: Dependency("PresentationCore", LoadHint.Always)]
[assembly: AssemblyVersion("4.0.1000.1000")]
//[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
