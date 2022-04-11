using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadLuaFileTest : MonoBehaviour
{
    public TextAsset textAsset;

    void Start()
    {
        //GlobalHelper.luaEnv.DoString(textAsset.text);
        GlobalHelper.luaEnv.DoString("require 'File'");
    }
}
