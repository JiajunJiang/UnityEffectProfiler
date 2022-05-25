using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Editor;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

public class ParticleTestPanel : EditorWindow
{
    public static ProfilerSetting Setting = null;

    public static List<string> particlePath = new List<string>();
    
    [MenuItem("Tools/Particle/ParticleProfiler")]
    public static void Open()
    {
        GetWindow<ParticleTestPanel>(true, "ParticleProfiler");
        CollectParticle();
    }

    private static void CollectParticle()
    {
        particlePath.Clear();
        Setting = AssetDatabase.LoadAssetAtPath<ProfilerSetting>("Assets/Editor/ParticleProfiler/Setting/ProfilerSetting.asset");
        Debug.Log(Setting.checkPath);
        var files = Directory.GetFiles(Application.dataPath + Setting.checkPath, "*.prefab", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            string atPath = "Assets" + file.Replace(Application.dataPath, string.Empty);
            var go = AssetDatabase.LoadAssetAtPath(atPath, typeof(GameObject)) as GameObject;
            if (go.GetComponent<ParticleSystem>() != null)
            {
                particlePath.Add(file);
                Debug.Log(file);
            }
        }
    }

    public void OnEnable()
    {
        
    }

    private void OnGUI()
    {
        Repaint();
        StartProfiler();
    }

    public void StartProfiler()
    {
        
    }
}
