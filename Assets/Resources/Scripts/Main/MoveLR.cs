using UnityEngine;
using System.Collections;

public class MoveLR : MonoBehaviour
{
    private const float Speed = 15.0f;

    void Start()
    {

    }

    void Update()
    {
        //力を加える
        //this.GetComponent<Rigidbody>().AddForce(
        //    Vector3.right * Input.GetAxisRaw("Horizontal") * Accel,
        //    ForceMode.Impulse
        //    );

        var pos = this.transform.position;
        pos.x += Input.GetAxisRaw("Horizontal") * Speed * Time.deltaTime;
        this.transform.position = pos;
    }
}