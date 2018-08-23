using UnityEngine;
using System.Collections;

public class WallUv : MonoBehaviour
{
    Vector2[] uv = new Vector2[24];

    void Awake()
    {
        // 左 : -x
        uv[2].x = 1.0f; uv[2].y = 1.0f;
        uv[3].x = 0.0f; uv[3].y = 1.0f;
        uv[0].x = 1.0f; uv[0].y = 0.0f;
        uv[1].x = 0.0f; uv[1].y = 0.0f;

        // 上 : +y
        uv[4].x = 1.0f; uv[4].y = 1.0f;
        uv[5].x = 1.0f; uv[5].y = 1.0f;
        uv[8].x = 1.0f; uv[8].y = 1.0f;
        uv[9].x = 1.0f; uv[9].y = 1.0f;

        // 後 : -z
        uv[23].x = 1.0f; uv[23].y = 0.0f;
        uv[21].x = 0.0f; uv[21].y = 1.0f;
        uv[20].x = 0.0f; uv[20].y = 0.0f;
        uv[22].x = 1.0f; uv[22].y = 1.0f;

        // 前 : +z
        uv[19].x = 1.0f; uv[19].y = 0.0f;
        uv[17].x = 0.0f; uv[17].y = 1.0f;
        uv[16].x = 0.0f; uv[16].y = 0.0f;
        uv[18].x = 1.0f; uv[18].y = 1.0f;

        // 下 : -y
        uv[15].x = 0.0f; uv[15].y = 0.0f;
        uv[13].x = 0.0f; uv[13].y = 0.0f;
        uv[12].x = 0.0f; uv[12].y = 0.0f;
        uv[14].x = 0.0f; uv[14].y = 0.0f;

        // 右 : +x
        uv[6].x = 0.0f; uv[6].y = 0.0f;
        uv[7].x = 1.0f; uv[7].y = 0.0f;
        uv[10].x = 0.0f; uv[10].y = 1.0f;
        uv[11].x = 1.0f; uv[11].y = 1.0f;
    }

    void Start()
    {
        MeshFilter mf = gameObject.GetComponent<MeshFilter>();
        mf.mesh.uv = uv;
    }
}