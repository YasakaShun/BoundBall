using UnityEngine;
using System.Collections;

public class BallCtrl : MonoBehaviour
{
    private enum State
    {
        Ready,
        Main,
    }

    public float speedX = 10.0f;
    public float speedY = 0.0f;
    public float maxMagnitude = 50.0f;
    public bool displayMagnitude = false;

    private State mState { get; set; }
    private bool mIsEnabled;

    public void OnGoal()
    {
        // バウンドしないようにする
        this.GetComponent<Collider>().material.bounciness = 0.01f;
    }

    void Start()
    {
        mState = State.Ready;
        this.GetComponent<Rigidbody>().useGravity = false;
    }

    void Update()
    {
        if (mState == State.Ready)
        {
            if (MainSceneManager.Instance.State == MainSceneManager.SceneState.Main)
            {
                mState = State.Main;
                // 動き出す
                this.GetComponent<Rigidbody>().AddForce(
                    new Vector3(speedX, speedY, 0.0f),
                    ForceMode.VelocityChange
                    );
                this.GetComponent<Rigidbody>().useGravity = true;
            }
        }
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