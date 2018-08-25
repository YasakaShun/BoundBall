using UnityEngine;
using UnityEngine.SceneManagement;
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

    public void Miss()
    {
        State = SceneState.Miss;
    }

    public void OnGoal()
    {
        State = SceneState.Goal;

        GameObject.Find("ResultCanvas").GetComponent<Canvas>().enabled = true;
    }

    void Awake()
    {
        Debug.Assert(Instance == null);
        Instance = this;
        State = SceneState.Ready;

        GameObject.Find("ResultCanvas").GetComponent<Canvas>().enabled = false;
    }

    void Start()
    {

    }

    void Update()
    {
    }
}