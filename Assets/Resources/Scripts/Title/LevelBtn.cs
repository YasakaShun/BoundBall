using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelBtn : MonoBehaviour
{
    public int Level = 1;

    public void Awake()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
        this.GetComponentInChildren<Text>().text = Level.ToString();
    }

    public void OnClick()
    {
        SceneManager.LoadScene("Level" + Level.ToString());
    }
}
