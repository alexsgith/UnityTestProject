using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EditorWindowTest : EditorWindow
{
   private string name;
   private int age;
   [MenuItem("Alex/MyTest")]
   public static void ShowWindow()
   {
      GetWindow<EditorWindowTest>("My Test Window");
   }

   private void OnGUI()
   {
      GUILayout.Label("Test Editor", EditorStyles.boldLabel);
      name = EditorGUILayout.TextField("Name", name);
      age = EditorGUILayout.IntField("Name", age);
      if (GUILayout.Button("submit"))
      {
         Debug.Log("name:"+name+" age:"+age );
      }
   }
}
