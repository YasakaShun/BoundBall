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
    public TimeCtrl TimeCtrl { get; private set; }

    public void RequestStart()
    {
        Debug.Log("Start");
        Debug.Assert(State == SceneState.Ready);
        State = SceneState.Main;
    }

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

        {
            string name = SceneManager.GetActiveScene().name;
            string head = "Level";
            int levelNo = int.Parse(name.Substring(name.IndexOf(head) + head.Length));
            var data = GameSystem.Instance.SaveDataManager.GetLevelData(levelNo);
            data.StarNum = 2;
            data.IsClear = true;
        }
    }

    void Awake()
    {
        Debug.Assert(Instance == null);
        Instance = this;

        State = SceneState.Ready;
        TimeCtrl = new TimeCtrl();

        Instantiate(ResourcesManager.CountDownCanvas);
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
            if (TimeCtrl.IsStop)
            {
                TimeCtrl.Play();
            }
            else
            {
                TimeCtrl.Stop();
            }
        }
    }
}