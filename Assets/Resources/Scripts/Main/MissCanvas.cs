using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissCanvas : MonoBehaviour
{
    void Start()
    {
        mIsMissed = false;

        this.GetComponent<Canvas>().enabled = false;
    }

    void Update()
    {
        if (mIsMissed)
        {
            return;
        }

        if (MainSceneManager.Instance.State == MainSceneManager.SceneState.Miss)
        {
            mIsMissed = true;
            this.GetComponent<Canvas>().enabled = true;
        }
    }

    private bool mIsMissed;
}
