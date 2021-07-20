using UnityEngine;
using UnityEditor;
using System;
using UnityEditor.SceneManagement;

public class CloudBuildHelper : MonoBehaviour
{
    [MenuItem("SetEnvironment/ToDevelop")]
    public static void SetEnvironmentToDevelop()
    {
        SetEnvironment(EnvironmentType.DEVELOP);
    }

    [MenuItem("SetEnvironment/ToProduct")]
    public static void SetEnvironmentToProduct()
    {
        SetEnvironment(EnvironmentType.PRODUCT);
    }


    private static void SetEnvironment(EnvironmentType targetEnvironment)
    {
        EditorSceneManager.OpenScene("Assets/Scenes/SampleScene.unity");
        EnvironmentConfig environmentConfig = GameObject.Find("EnvironmentManager").GetComponent<EnvironmentConfig>();

        environmentConfig.EnvironmentType = targetEnvironment;

        Undo.RecordObject(environmentConfig, "Update");
        EditorUtility.SetDirty(environmentConfig);

        EditorSceneManager.SaveOpenScenes();
    }
}