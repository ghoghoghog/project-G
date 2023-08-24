using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(camera_mode_changer))]
public class camera_mode_changerEditor : Editor
{
    camera_mode_changer c_mode_ch = null;
    void OnEnable()
    {
        c_mode_ch = (camera_mode_changer)target;
    }
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        serializedObject.Update();

        switch (c_mode_ch.mode)
        {
            case camera_mode.x_rail:
                SerializedProperty X_N_Property = serializedObject.FindProperty("m");
                SerializedProperty X_use = serializedObject.FindProperty("use_min_max");
                EditorGUILayout.PropertyField(X_N_Property);
                EditorGUILayout.PropertyField(X_use);
                if (c_mode_ch.use_min_max)
                {
                    SerializedProperty X_min = serializedObject.FindProperty("min_m");
                    SerializedProperty X_max = serializedObject.FindProperty("max_m");
                    EditorGUILayout.PropertyField(X_min);
                    EditorGUILayout.PropertyField(X_max);

                }

                break;
            case camera_mode.y_rail:
                SerializedProperty Y_N_Property = serializedObject.FindProperty("m");
                SerializedProperty Y_use = serializedObject.FindProperty("use_min_max");
                EditorGUILayout.PropertyField(Y_N_Property);
                EditorGUILayout.PropertyField(Y_use);
                if (c_mode_ch.use_min_max)
                {
                    SerializedProperty X_min = serializedObject.FindProperty("min_m");
                    SerializedProperty X_max = serializedObject.FindProperty("max_m");
                    EditorGUILayout.PropertyField(X_min);
                    EditorGUILayout.PropertyField(X_max);

                }
                break;
            case camera_mode.player_follow:
                break;
            case camera_mode.screen_follow:
                SerializedProperty Pos_Property = serializedObject.FindProperty("pos");
                EditorGUILayout.PropertyField(Pos_Property);

                break;
        }


        serializedObject.ApplyModifiedProperties();
    }
}