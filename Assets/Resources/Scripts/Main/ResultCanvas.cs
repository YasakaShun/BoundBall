using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultCanvas : MonoBehaviour
{
    void Start()
    {
        mIsCleared = false;

        this.GetComponent<Canvas>().enabled = false;
    }

    void Update()
    {
        if (mIsCleared)
        {
            return;
        }

        if (MainSceneManager.Instance.State == MainSceneManager.SceneState.Goal)
        {
            mIsCleared = true;
            this.GetComponent<Canvas>().enabled = true;
        }
    }

    private bool mIsCleared;
}
