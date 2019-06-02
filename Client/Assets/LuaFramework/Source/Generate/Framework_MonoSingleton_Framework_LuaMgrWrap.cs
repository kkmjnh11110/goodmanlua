﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Framework_MonoSingleton_Framework_LuaMgrWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Framework.MonoSingleton<Framework.LuaMgr>), typeof(UnityEngine.MonoBehaviour), "MonoSingleton_Framework_LuaMgr");
		L.RegFunction("Init", Init);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Instance", get_Instance, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.MonoSingleton<Framework.LuaMgr>.Init");
#endif
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.MonoSingleton<Framework.LuaMgr> obj = (Framework.MonoSingleton<Framework.LuaMgr>)ToLua.CheckObject<Framework.MonoSingleton<Framework.LuaMgr>>(L, 1);
			obj.Init();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.MonoSingleton<Framework.LuaMgr>.op_Equality");
#endif
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.MonoSingleton<Framework.LuaMgr>.Instance");
#endif
		try
		{
			ToLua.Push(L, Framework.MonoSingleton<Framework.LuaMgr>.Instance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

