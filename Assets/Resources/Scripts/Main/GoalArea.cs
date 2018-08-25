using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalArea : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Debug.Log("Goal!!");
            other.gameObject.GetComponent<BallCtrl>().OnGoal();
            MainSceneManager.Instance.OnGoal();
        }
    }
}
