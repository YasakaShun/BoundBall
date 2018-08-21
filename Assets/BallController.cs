using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{

    public float speedX = 10.0f;
    public float speedY = 0.0f;

    // Use this for initialization
    void Start()
    {
        var vel = new Vector3(speedX, speedY, 0.0f);
        this.GetComponent<Rigidbody>().AddForce(
            vel,
            ForceMode.VelocityChange);

    }

    // Update is called once per frame
    void Update()
    {

    }
}