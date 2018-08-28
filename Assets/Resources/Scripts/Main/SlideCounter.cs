using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SlideCounter
{
    private const float Speed = 15.0f;

    public float ScrollValue { get; private set; }
    public float GoalLength { get; private set; }

    public SlideCounter()
    {
        ScrollValue = 0.0f;
        GoalLength = GameObject.Find("Goal").transform.position.x;
    }

    public void Update()
    {
        if (MainSceneManager.Instance.State != MainSceneManager.SceneState.Main)
        {
            return;
        }

        if (MainSceneManager.Instance.TimeCtrl.IsStop)
        {
            return;
        }

        if (MainSceneManager.Instance.IsHoldL)
        {
            ScrollValue -= Speed * Time.deltaTime;
        }
        else if (MainSceneManager.Instance.IsHoldL)
        {
            ScrollValue += Speed * Time.deltaTime;
        }
        else
        {
            ScrollValue += Input.GetAxisRaw("Horizontal") * Speed * Time.deltaTime;
        }
    }
}