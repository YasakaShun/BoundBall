using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDownCanvas : MonoBehaviour
{
    void Start()
    {
        mCount = 3;
        mTime = 0.0f;

        SetText(mCount.ToString());
    }

    void Update()
    {
        mTime += Time.deltaTime;
        if (1.0f < mTime)
        {
            mTime -= 1.0f;
            --mCount;

            if (mCount == 0)
            {
                MainSceneManager.Instance.RequestStart();
                Destroy(this.gameObject);
            }
            else
            {
                SetText(mCount.ToString());
            }
        }
    }

    private void SetText(string str)
    {
        this.GetComponentInChildren<Text>().text = str;
    }

    private int mCount;
    private float mTime;
}
