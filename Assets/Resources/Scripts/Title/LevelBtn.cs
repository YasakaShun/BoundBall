using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelBtn : MonoBehaviour
{
    public int Level = 1;

    public void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
        this.GetComponentInChildren<Text>().text = Level.ToString();

        var data = GameSystem.Instance.SaveDataManager.GetLevelData(Level);
        for (int i = 0; i < SaveDataManager.MaxStarNum; ++i)
        {
            this.transform.Find("Star" + (i+1).ToString()).gameObject.SetActive(false);
        }
        for (int i = 0; i < data.StarNum; ++i)
        {
            this.transform.Find("Star" + (i + 1).ToString()).gameObject.SetActive(true);
        }
        this.transform.Find("Clear").gameObject.SetActive(data.IsClear);
    }

    public void OnClick()
    {
        SceneManager.LoadScene("Level" + Level.ToString());
    }
}
