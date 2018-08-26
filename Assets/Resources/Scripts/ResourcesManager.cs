using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Resource アクセスの仲介
/// </summary>
public class ResourcesManager
{
    public static GameObject MissCanvas = (GameObject)Resources.Load("Prefabs/Main/MissCanvas");
    public static GameObject ResultCanvas = (GameObject)Resources.Load("Prefabs/Main/ResultCanvas");
}
