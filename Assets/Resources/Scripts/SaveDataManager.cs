using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveDataManager
{
    public const int MaxStarNum = 3;
    public const int MaxLevelNum = 5;

    private List<LevelData> Data { get; set; }

    public SaveDataManager()
    {
        Data = Enumerable.Repeat(new LevelData(), MaxLevelNum).ToList();
    }

    // 見た目のステージ番号を内部のindexに変換して適切なデータを返す
    public LevelData GetLevelData(int levelNo)
    {
        Debug.Assert(1 <= levelNo && levelNo <= MaxLevelNum);
        return Data[levelNo - 1];
    }

}
