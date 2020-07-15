using System;
using System.Reflection;
using System.Windows.Forms;

// Token: 0x02000008 RID: 8
internal static class Class4
{
	// Token: 0x06000022 RID: 34 RVA: 0x000022F4 File Offset: 0x000004F4
	internal static string PBaBSwF0biKAJ(Assembly assembly)
	{
		if (assembly == typeof(Class4).Assembly)
		{
			return Application.ExecutablePath;
		}
		return assembly.Location;
	}
}
