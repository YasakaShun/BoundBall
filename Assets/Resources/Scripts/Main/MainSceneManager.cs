using UnityEngine;
using System.Collections;

public class MainSceneManager : MonoBehaviour
{
    enum SceneState
    {
        Ready,
        Main,
        Miss,
        Goal,
        TERM
    }

    public static MainSceneManager Instance { get; private set; }
    private SceneState State { get; set; }

    void Awake()
    {
        Debug.Assert(Instance == null);
        Instance = this;
        State = SceneState.Ready;
    }

    public void Miss()
    {
        State = SceneState.Miss;
    }

    public void OnGoal()
    {
        State = SceneState.Goal;
    }

    void Start()
    {

    }

    void Update()
    {
    }
}