using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelData
{
    public int StarNum { get; set; }
    public bool IsClear { get; set; }

    public LevelData()
    {
        StarNum = 0;
        IsClear = false;
    }

}
