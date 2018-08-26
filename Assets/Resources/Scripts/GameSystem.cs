using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    public static GameSystem Instance { get; private set; }

    public SaveDataManager SaveDataManager { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        SaveDataManager = new SaveDataManager();
    }

    private void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

    }
}
