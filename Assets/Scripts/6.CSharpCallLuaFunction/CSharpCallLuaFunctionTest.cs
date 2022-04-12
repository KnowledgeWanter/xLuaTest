using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CSharpCallLuaFunctionTest : MonoBehaviour
{
    [XLua.CSharpCallLua]
    public delegate void delegate_1();
    [XLua.CSharpCallLua]
    public delegate int delegate_2(int v1,int v2);

    void Start()
    {
        GlobalHelper.luaEnv.DoString("require 'File'");
        delegate_1 act = GlobalHelper.luaEnv.Global.Get<delegate_1>("f3");
        act();

        delegate_2 act2 = GlobalHelper.luaEnv.Global.Get<delegate_2>("f4");
        int result = act2(10, 20);
        Debug.Log("result:" + result);
    }
}
