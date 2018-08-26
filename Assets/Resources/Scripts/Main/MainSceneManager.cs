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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnMiss()
    {
        State = SceneState.Miss;

        Instantiate(ResourcesManager.MissCanvas);
    }

    public void OnGoal()
    {
        State = SceneState.Goal;

        Instantiate(ResourcesManager.ResultCanvas);
    }

    void Awake()
    {
        Debug.Assert(Instance == null);
        Instance = this;

        State = SceneState.Main;
        mTimeCtrl = new TimeCtrl();
    }

    void Start()
    {
    }

    void Update()
    {
        if (State != SceneState.Main)
        {
            return;
        }

        if (Input.GetKeyDown("space"))
        {
            if (mTimeCtrl.IsStop)
            {
                mTimeCtrl.Play();
            }
            else
            {
                mTimeCtrl.Stop();
            }
        }
    }

    TimeCtrl mTimeCtrl;
}