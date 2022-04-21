using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuaCallCSharpTest : MonoBehaviour
{
    void Start()
    {
        GlobalHelper.luaEnv.DoString("require 'File2'");
    }
}