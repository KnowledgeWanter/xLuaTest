using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorldTest : MonoBehaviour
{
    void Start()
    {
        GlobalHelper.luaEnv.DoString("print('HelloWorld.')");
    }
}
