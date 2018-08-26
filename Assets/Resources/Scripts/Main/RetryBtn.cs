using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RetryBtn : MonoBehaviour
{
    void Awake()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        MainSceneManager.Instance.RequestRetry();
    }
}
