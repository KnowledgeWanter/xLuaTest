using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSharpeCallLuaVarTest : MonoBehaviour
{
    void Start()
    {
        GlobalHelper.luaEnv.DoString("require 'File'");

        int num1 = GlobalHelper.luaEnv.Global.Get<int>("num1");
        Debug.Log("num1:" + num1);
        string str1 = GlobalHelper.luaEnv.Global.Get<string>("str1");
        Debug.Log("str1:" + str1);
        num1 = 100;
        GlobalHelper.luaEnv.DoString("print(num1)");
        GlobalHelper.luaEnv.Global.Set("num1", 100);
        GlobalHelper.luaEnv.DoString("print(num1)");
        GlobalHelper.luaEnv.Global.Set("str1", "Test");
        GlobalHelper.luaEnv.DoString("print(str1)");

        //创建新虚拟机
        XLua.LuaEnv luaEnv2 = new XLua.LuaEnv();
        luaEnv2.DoString("require 'File'");
        Debug.Log("num1:" + luaEnv2.Global.Get<int>("num1"));
        Debug.Log("str1:" + luaEnv2.Global.Get<string>("str1"));
    }
}
