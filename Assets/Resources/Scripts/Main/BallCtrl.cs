using UnityEngine;
using System.Collections;

public class BallCtrl : MonoBehaviour
{
    public float speedX = 10.0f;
    public float speedY = 0.0f;
    public float maxMagnitude = 50.0f;
    public bool displayMagnitude = false;

    public void OnGoal()
    {
        // バウンドしないようにする
        this.GetComponent<Collider>().material.bounciness = 0.01f;
    }

    void Start()
    {
        this.GetComponent<Rigidbody>().AddForce(
            new Vector3(speedX, speedY, 0.0f),
            ForceMode.VelocityChange
            );

    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        var rigidbody = this.GetComponent<Rigidbody>();
        rigidbody.velocity = Vector3.ClampMagnitude(rigidbody.velocity, maxMagnitude);
        if (displayMagnitude)
        {
            Debug.Log(rigidbody.velocity.magnitude);
        }
    }
}