// Decompiled with JetBrains decompiler
// Type: Projectcrypto.Settings

using System;

namespace Projectcrypto
{
  internal static class Settings
  {
    public static string Folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Performance/";
    public static string Owner;
    public static string Version;
  }
}
