using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class CSharpCallLuaTableTest2 : MonoBehaviour
{
    void Start()
    {
        GlobalHelper.luaEnv.DoString("require 'File'");
        IPerson _iperson = GlobalHelper.luaEnv.Global.Get<IPerson>("t1");
        Debug.Log("name:" + _iperson.name);
        Debug.Log("age:" + _iperson.age);
        _iperson.mm();
    }

    [CSharpCallLua]
    public interface IPerson
    { 
        string name { get; set; }
        int age { get; set; }
        void mm();
    }
}
