using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TimeCtrl
{
    public bool IsStop
    {
        get { return Time.timeScale == 0.0f; }
    }

    public void Stop()
    {
        Time.timeScale = 0.0f;
    }

    public void Play()
    {
        Time.timeScale = 1.0f;
    }
}