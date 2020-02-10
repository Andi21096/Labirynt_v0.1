using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pilot : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 direction;
    public Rigidbody go;
    public float acceleration;
    void Start()
    {
        
    }

    float speed = 2.0f;
    void Update()
    {
        
            Vector3 dir = new Vector3();

            dir.x = Input.acceleration.x;
            dir.z = Input.acceleration.y;

            if (dir.sqrMagnitude > 1)
                dir.Normalize();

            dir *= Time.deltaTime;

        // Move object
        //transform.Translate(dir * speed);
        //if (Input.GetMouseButtonDown(0))
        go.AddForce(dir.normalized * acceleration, ForceMode.Impulse);

       
    }
    private void OnTriggerStay(Collider other)      //funkcja jest wywołana gdy jest aktywowany trigger      
    {
        if (other.gameObject.tag == "Wall")         //jeżeli objekt ma tag "Wall" 
        {
            Vector3 dir = new Vector3();

            dir.x = Input.acceleration.x;
            dir.z = Input.acceleration.y;

            if (dir.sqrMagnitude > 0.1)
                dir.Normalize();

            dir *= Time.deltaTime;
            transform.Translate(dir * (-speed));   
        }                                          
    }

}
