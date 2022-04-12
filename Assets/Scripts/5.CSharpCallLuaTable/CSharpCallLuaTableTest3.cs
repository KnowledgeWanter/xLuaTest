using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSharpCallLuaTableTest3 : MonoBehaviour
{
    private void Start()
    {
        GlobalHelper.luaEnv.DoString("require 'File'");
        List<object> list = GlobalHelper.luaEnv.Global.Get<List<object>>("t1");
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i].ToString());        
        }
        Debug.Log("----------------------");
        Dictionary<string, object> dic = GlobalHelper.luaEnv.Global.Get<Dictionary<string, object>>("t1");
        foreach (var item in dic)
        {
            Debug.Log(item.Key + ":" + item.Value.ToString());
        }
    }
}