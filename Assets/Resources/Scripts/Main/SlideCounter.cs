using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SlideCounter
{
    private const float Speed = 15.0f;

    public float ScrollValue { get; private set; }

    public SlideCounter()
    {
        ScrollValue = 0.0f;
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

        ScrollValue += Input.GetAxisRaw("Horizontal") * Speed * Time.deltaTime;
    }
}