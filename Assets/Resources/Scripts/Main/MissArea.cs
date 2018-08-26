using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissArea : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (MainSceneManager.Instance.State != MainSceneManager.SceneState.Main)
        {
            return;
        }

        if (other.gameObject.tag == "Ball")
        {
            Debug.Log("Miss!");
            MainSceneManager.Instance.OnMiss();
        }
    }
}
