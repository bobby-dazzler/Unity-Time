using UnityEditor;
using UnityEngine;
using UnityTime;

[CustomEditor(typeof(TimeData))]
public class TimeDataEditor : Editor {

    public override void OnInspectorGUI() {
        TimeData timeData = (TimeData)target;
        DrawDefaultInspector();

        if (GUILayout.Button("Pause")) {
            timeData.SetTimeScale(0);
        }
        if (GUILayout.Button("Normal Speed")) {
            timeData.SetTimeScale(1);
        }
        if (GUILayout.Button("x2 Speed")) {
            timeData.SetTimeScale(2);
        }
        if (GUILayout.Button("x3 Speed")) {
            timeData.SetTimeScale(3);
        }
    }
}