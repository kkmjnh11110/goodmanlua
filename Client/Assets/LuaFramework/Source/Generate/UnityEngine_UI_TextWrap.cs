﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_UI_TextWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.UI.Text), typeof(UnityEngine.UI.MaskableGraphic));
		L.RegFunction("FontTextureChanged", FontTextureChanged);
		L.RegFunction("GetGenerationSettings", GetGenerationSettings);
		L.RegFunction("GetTextAnchorPivot", GetTextAnchorPivot);
		L.RegFunction("CalculateLayoutInputHorizontal", CalculateLayoutInputHorizontal);
		L.RegFunction("CalculateLayoutInputVertical", CalculateLayoutInputVertical);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("cachedTextGenerator", get_cachedTextGenerator, null);
		L.RegVar("cachedTextGeneratorForLayout", get_cachedTextGeneratorForLayout, null);
		L.RegVar("mainTexture", get_mainTexture, null);
		L.RegVar("font", get_font, set_font);
		L.RegVar("text", get_text, set_text);
		L.RegVar("supportRichText", get_supportRichText, set_supportRichText);
		L.RegVar("resizeTextForBestFit", get_resizeTextForBestFit, set_resizeTextForBestFit);
		L.RegVar("resizeTextMinSize", get_resizeTextMinSize, set_resizeTextMinSize);
		L.RegVar("resizeTextMaxSize", get_resizeTextMaxSize, set_resizeTextMaxSize);
		L.RegVar("alignment", get_alignment, set_alignment);
		L.RegVar("alignByGeometry", get_alignByGeometry, set_alignByGeometry);
		L.RegVar("fontSize", get_fontSize, set_fontSize);
		L.RegVar("horizontalOverflow", get_horizontalOverflow, set_horizontalOverflow);
		L.RegVar("verticalOverflow", get_verticalOverflow, set_verticalOverflow);
		L.RegVar("lineSpacing", get_lineSpacing, set_lineSpacing);
		L.RegVar("fontStyle", get_fontStyle, set_fontStyle);
		L.RegVar("pixelsPerUnit", get_pixelsPerUnit, null);
		L.RegVar("minWidth", get_minWidth, null);
		L.RegVar("preferredWidth", get_preferredWidth, null);
		L.RegVar("flexibleWidth", get_flexibleWidth, null);
		L.RegVar("minHeight", get_minHeight, null);
		L.RegVar("preferredHeight", get_preferredHeight, null);
		L.RegVar("flexibleHeight", get_flexibleHeight, null);
		L.RegVar("layoutPriority", get_layoutPriority, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FontTextureChanged(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.FontTextureChanged");
#endif
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)ToLua.CheckObject<UnityEngine.UI.Text>(L, 1);
			obj.FontTextureChanged();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGenerationSettings(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.GetGenerationSettings");
#endif
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)ToLua.CheckObject<UnityEngine.UI.Text>(L, 1);
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			UnityEngine.TextGenerationSettings o = obj.GetGenerationSettings(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTextAnchorPivot(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.GetTextAnchorPivot");
#endif
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.TextAnchor arg0 = (UnityEngine.TextAnchor)ToLua.CheckObject(L, 1, typeof(UnityEngine.TextAnchor));
			UnityEngine.Vector2 o = UnityEngine.UI.Text.GetTextAnchorPivot(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateLayoutInputHorizontal(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.CalculateLayoutInputHorizontal");
#endif
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)ToLua.CheckObject<UnityEngine.UI.Text>(L, 1);
			obj.CalculateLayoutInputHorizontal();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateLayoutInputVertical(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.CalculateLayoutInputVertical");
#endif
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)ToLua.CheckObject<UnityEngine.UI.Text>(L, 1);
			obj.CalculateLayoutInputVertical();
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
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.op_Equality");
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
	static int get_cachedTextGenerator(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.cachedTextGenerator");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			UnityEngine.TextGenerator ret = obj.cachedTextGenerator;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cachedTextGenerator on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cachedTextGeneratorForLayout(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.cachedTextGeneratorForLayout");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			UnityEngine.TextGenerator ret = obj.cachedTextGeneratorForLayout;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cachedTextGeneratorForLayout on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mainTexture(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.mainTexture");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			UnityEngine.Texture ret = obj.mainTexture;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mainTexture on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_font(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.font");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			UnityEngine.Font ret = obj.font;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index font on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_text(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.text");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			string ret = obj.text;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index text on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_supportRichText(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.supportRichText");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			bool ret = obj.supportRichText;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index supportRichText on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_resizeTextForBestFit(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.resizeTextForBestFit");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			bool ret = obj.resizeTextForBestFit;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index resizeTextForBestFit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_resizeTextMinSize(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.resizeTextMinSize");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			int ret = obj.resizeTextMinSize;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index resizeTextMinSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_resizeTextMaxSize(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.resizeTextMaxSize");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			int ret = obj.resizeTextMaxSize;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index resizeTextMaxSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_alignment(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.alignment");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			UnityEngine.TextAnchor ret = obj.alignment;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index alignment on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_alignByGeometry(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.alignByGeometry");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			bool ret = obj.alignByGeometry;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index alignByGeometry on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fontSize(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.fontSize");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			int ret = obj.fontSize;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fontSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_horizontalOverflow(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.horizontalOverflow");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			UnityEngine.HorizontalWrapMode ret = obj.horizontalOverflow;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index horizontalOverflow on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_verticalOverflow(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.verticalOverflow");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			UnityEngine.VerticalWrapMode ret = obj.verticalOverflow;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index verticalOverflow on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lineSpacing(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.lineSpacing");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			float ret = obj.lineSpacing;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index lineSpacing on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fontStyle(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.fontStyle");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			UnityEngine.FontStyle ret = obj.fontStyle;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fontStyle on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pixelsPerUnit(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.pixelsPerUnit");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			float ret = obj.pixelsPerUnit;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pixelsPerUnit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_minWidth(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.minWidth");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			float ret = obj.minWidth;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index minWidth on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_preferredWidth(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.preferredWidth");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			float ret = obj.preferredWidth;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index preferredWidth on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_flexibleWidth(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.flexibleWidth");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			float ret = obj.flexibleWidth;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index flexibleWidth on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_minHeight(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.minHeight");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			float ret = obj.minHeight;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index minHeight on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_preferredHeight(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.preferredHeight");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			float ret = obj.preferredHeight;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index preferredHeight on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_flexibleHeight(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.flexibleHeight");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			float ret = obj.flexibleHeight;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index flexibleHeight on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_layoutPriority(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.layoutPriority");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			int ret = obj.layoutPriority;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index layoutPriority on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_font(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.font");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			UnityEngine.Font arg0 = (UnityEngine.Font)ToLua.CheckObject(L, 2, typeof(UnityEngine.Font));
			obj.font = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index font on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_text(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.text");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.text = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index text on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_supportRichText(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.supportRichText");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.supportRichText = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index supportRichText on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_resizeTextForBestFit(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.resizeTextForBestFit");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.resizeTextForBestFit = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index resizeTextForBestFit on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_resizeTextMinSize(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.resizeTextMinSize");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.resizeTextMinSize = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index resizeTextMinSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_resizeTextMaxSize(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.resizeTextMaxSize");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.resizeTextMaxSize = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index resizeTextMaxSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_alignment(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.alignment");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			UnityEngine.TextAnchor arg0 = (UnityEngine.TextAnchor)ToLua.CheckObject(L, 2, typeof(UnityEngine.TextAnchor));
			obj.alignment = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index alignment on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_alignByGeometry(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.alignByGeometry");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.alignByGeometry = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index alignByGeometry on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fontSize(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.fontSize");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.fontSize = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fontSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_horizontalOverflow(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.horizontalOverflow");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			UnityEngine.HorizontalWrapMode arg0 = (UnityEngine.HorizontalWrapMode)ToLua.CheckObject(L, 2, typeof(UnityEngine.HorizontalWrapMode));
			obj.horizontalOverflow = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index horizontalOverflow on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_verticalOverflow(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.verticalOverflow");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			UnityEngine.VerticalWrapMode arg0 = (UnityEngine.VerticalWrapMode)ToLua.CheckObject(L, 2, typeof(UnityEngine.VerticalWrapMode));
			obj.verticalOverflow = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index verticalOverflow on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lineSpacing(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.lineSpacing");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.lineSpacing = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index lineSpacing on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fontStyle(IntPtr L)
	{
#if UNITY_EDITOR
        ToluaProfiler.AddCallRecord("UnityEngine.UI.Text.fontStyle");
#endif
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.Text obj = (UnityEngine.UI.Text)o;
			UnityEngine.FontStyle arg0 = (UnityEngine.FontStyle)ToLua.CheckObject(L, 2, typeof(UnityEngine.FontStyle));
			obj.fontStyle = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fontStyle on a nil value");
		}
	}
}

