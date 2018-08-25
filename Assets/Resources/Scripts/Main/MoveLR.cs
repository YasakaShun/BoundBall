using UnityEngine;
using System.Collections;

public class MoveLR : MonoBehaviour
{
    private const float Accel = 1000.0f;

    void Start()
    {

    }

    void Update()
    {
        //力を加える
        this.GetComponent<Rigidbody>().AddForce(
            Vector3.right * Input.GetAxisRaw("Horizontal") * Accel,
            ForceMode.Impulse
            );
    }
}