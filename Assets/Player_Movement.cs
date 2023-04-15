
using UnityEngine;

public class Player_Movement : MonoBehaviour
{   // This is creating a refrence to RigidBody variable  
    public Rigidbody rb;
    public float Forwardforce  = 2000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // use void Fixedupdate() instead of void update() when using Physics system
    void FixedUpdate()
    {
        rb.AddForce(0,0,Forwardforce * Time.deltaTime);
    }
}
