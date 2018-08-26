using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainSceneManager : MonoBehaviour
{
    public enum SceneState
    {
        Ready,
        Main,
        Miss,
        Goal,
        TERM
    }

    public static MainSceneManager Instance { get; private set; }
    public SceneState State { get; private set; }

    public void RequestTitle()
    {
        Debug.Log("Title");
        SceneManager.LoadScene("Title");
    }

    public void RequestRetry()
    {
        Debug.Log("Restart");
        // TODO: 今いるシーンをリスタートする
        SceneManager.LoadScene("Level0");
    }

    public void OnMiss()
    {
        State = SceneState.Miss;
    }

    public void OnGoal()
    {
        State = SceneState.Goal;
    }

    void Awake()
    {
        Debug.Assert(Instance == null);
        Instance = this;
    }

    void Start()
    {
        State = SceneState.Main;
    }

    void Update()
    {
    }
}