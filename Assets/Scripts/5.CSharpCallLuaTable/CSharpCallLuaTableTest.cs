using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSharpCallLuaTableTest : MonoBehaviour
{
    void Start()
    {
        GlobalHelper.luaEnv.DoString("require 'File'");
        Person _person = GlobalHelper.luaEnv.Global.Get<Person>("t1");
        Debug.Log("name:" + _person.name);
        Debug.Log("age:" + _person.age);

        _person.name = "zone";
        _person.age = 18;
        GlobalHelper.luaEnv.DoString("print(t1.name)");
        GlobalHelper.luaEnv.DoString("print(t1.age)");

    }

    public class Person
    {
        public string name;
        public int age;
    }
}
