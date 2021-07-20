using UnityEngine;
using UnityEditor;
using System;

public class CloudBuildHelper : MonoBehaviour
{
    public static void PreExport()
    {
        //PlayerSettings.bundleVersion = String.Format("1.0.{0}", manifest.GetValue("buildNumber", "unknown"));
        Debug.LogWarning("@@@@ call CloudBuildHelper#PreExport");
    }
}