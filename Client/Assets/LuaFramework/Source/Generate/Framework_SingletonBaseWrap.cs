﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Framework_SingletonBaseWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Framework.SingletonBase), typeof(Framework.Singletoninterface));
		L.RegFunction("Launch", Launch);
		L.RegFunction("SingletoninterfaceOnInitialize", SingletoninterfaceOnInitialize);
		L.RegFunction("SingletoninterfaceOnUninitialize", SingletoninterfaceOnUninitialize);
		L.RegFunction("New", _CreateFramework_SingletonBase);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("OnInitializeHandler", get_OnInitializeHandler, set_OnInitializeHandler);
		L.RegVar("OnUninitializeHandler", get_OnUninitializeHandler, set_OnUninitializeHandler);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFramework_SingletonBase(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.SingletonBase.ctor");
#endif
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Framework.SingletonBase obj = new Framework.SingletonBase();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Framework.SingletonBase.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Launch(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.SingletonBase.Launch");
#endif
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.SingletonBase obj = (Framework.SingletonBase)ToLua.CheckObject<Framework.SingletonBase>(L, 1);
			obj.Launch();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SingletoninterfaceOnInitialize(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.SingletonBase.SingletoninterfaceOnInitialize");
#endif
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.SingletonBase obj = (Framework.SingletonBase)ToLua.CheckObject<Framework.SingletonBase>(L, 1);
			obj.SingletoninterfaceOnInitialize();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SingletoninterfaceOnUninitialize(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.SingletonBase.SingletoninterfaceOnUninitialize");
#endif
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.SingletonBase obj = (Framework.SingletonBase)ToLua.CheckObject<Framework.SingletonBase>(L, 1);
			obj.SingletoninterfaceOnUninitialize();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnInitializeHandler(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.SingletonBase.OnInitializeHandler");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Framework.SingletonBase obj = (Framework.SingletonBase)o;
			Framework.OnInitializeFinishedHandler ret = obj.OnInitializeHandler;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index OnInitializeHandler on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnUninitializeHandler(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.SingletonBase.OnUninitializeHandler");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Framework.SingletonBase obj = (Framework.SingletonBase)o;
			Framework.OnUninitializeStartHandler ret = obj.OnUninitializeHandler;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index OnUninitializeHandler on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnInitializeHandler(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.SingletonBase.OnInitializeHandler");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Framework.SingletonBase obj = (Framework.SingletonBase)o;
			Framework.OnInitializeFinishedHandler arg0 = (Framework.OnInitializeFinishedHandler)ToLua.CheckDelegate<Framework.OnInitializeFinishedHandler>(L, 2);
			obj.OnInitializeHandler = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index OnInitializeHandler on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnUninitializeHandler(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("Framework.SingletonBase.OnUninitializeHandler");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Framework.SingletonBase obj = (Framework.SingletonBase)o;
			Framework.OnUninitializeStartHandler arg0 = (Framework.OnUninitializeStartHandler)ToLua.CheckDelegate<Framework.OnUninitializeStartHandler>(L, 2);
			obj.OnUninitializeHandler = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index OnUninitializeHandler on a nil value");
		}
	}
}

