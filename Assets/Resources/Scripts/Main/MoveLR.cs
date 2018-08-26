using UnityEngine;
using System.Collections;

public class MoveLR : MonoBehaviour
{
    void Start()
    {
        mFirstPos = this.transform.position;
    }

    void Update()
    {
        if (MainSceneManager.Instance.State != MainSceneManager.SceneState.Main)
        {
            return;
        }

        if (MainSceneManager.Instance.TimeCtrl.IsStop)
        {
            return;
        }

        var pos = mFirstPos;
        pos.x += MainSceneManager.Instance.SlideCounter.ScrollValue;
        this.transform.position = pos;
    }

    private Vector3 mFirstPos;
}