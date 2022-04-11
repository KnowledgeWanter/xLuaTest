using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomLoaderTest : MonoBehaviour
{
    void Start()
    {
        GlobalHelper.luaEnv.AddLoader(customLoader);
        GlobalHelper.luaEnv.DoString("require 'File_1'");
    }

    byte[] customLoader(ref string fileName)
    {
        string filePath = fileName + ".lua";
        TextAsset textAsset = Resources.Load<TextAsset>(filePath);
        if (textAsset != null)
        {
            Debug.Log("customLoader Complete.");
            return System.Text.Encoding.UTF8.GetBytes(textAsset.text);
        }
        else
        {
            string strError = string.Format("print('{0} is null!')", fileName);
            return System.Text.Encoding.UTF8.GetBytes(strError);
        }
    }
}
