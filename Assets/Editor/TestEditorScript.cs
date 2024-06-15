using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(MyTestScript))]
public class TestEditorScript : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        MyTestScript test = (MyTestScript)target;
        if (GUILayout.Button("Click Me"))
        {
            
            Debug.Log(test.name+"Clicked");
        }
        
    }
}
