using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuaCallComponentTest : MonoBehaviour
{
    void Start()
    {
        GlobalHelper.luaEnv.DoString("require 'File3'");

        //GameObject objLight = GameObject.Find("Directional Light");
        //Light _light = objLight.GetComponent<Light>();
        //GameObject.Destroy(_light);
    }
}
