//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerBehaviour : MonoBehaviour
{
    /// <summary>
    /// A reference to the Rigidbody component
    /// </summary>
    private Rigidbody rb;

    [Tooltip("How fast the ball moves left/right")]
    public float dodgeSpeed = 5;

    [Tooltip("How fast the ball moves forwards automatically")]
    [Range(0, 10)]
    public float rollSpeed = 5;

    //Start is called before the first frame update
    void Start()
    {
        //Get access to our Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    // void Update is called once per frame

    /// <summary>
    /// FixedUpdate is called at a fixed framerate and is a prime place 
            /// to put 
    /// Anything based on time.
    /// </summary>
    private void FixedUpdate()
    {
        //Check if we're moving to the side
        var horizontalSpeed = Input.GetAxis("Horizontal") * dodgeSpeed;
        rb.AddForce(horizontalSpeed, 0, rollSpeed);
    }
}