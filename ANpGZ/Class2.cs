using System;
using System.Reflection;

// Token: 0x02000005 RID: 5
internal class Class2
{
	// Token: 0x06000019 RID: 25 RVA: 0x00003B08 File Offset: 0x00001D08
	internal static void FayBSw88gI5Nk(int typemdt)
	{
		Type type = Class2.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class2.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000022BC File Offset: 0x000004BC
	public Class2()
	{
		Class3.q1CBSw8zt8A0W();
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000022C9 File Offset: 0x000004C9
	static Class2()
	{
		Class3.q1CBSw8zt8A0W();
		Class2.module_0 = typeof(Class2).Assembly.ManifestModule;
	}

	// Token: 0x0400000C RID: 12
	internal static Module module_0;

	// Token: 0x02000006 RID: 6
	// (Invoke) Token: 0x0600001D RID: 29
	internal delegate void Delegate0(object o);
}
