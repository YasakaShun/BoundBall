using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissArea : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Debug.Log("Restart");
            // TODO: 今いるシーンをリスタートする
            SceneManager.LoadScene("Level0");
        }
    }
}
