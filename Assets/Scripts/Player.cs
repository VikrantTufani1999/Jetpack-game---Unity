using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody body;

    

    private float Horizontal;

    public float speed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            body.AddForce(new Vector3(0, speed, 0), ForceMode.Acceleration);
            
        }
        else if(Input.GetMouseButtonUp(0))
        {
            body.velocity *= 0.5f;
            
            
        }
        /*if (Input.GetAxis("Mouse X") > 0)
        {
            //Code for action on mouse moving left
            body.AddForce(new Vector3(5, 0, 0), ForceMode.Force);
            print("Mouse moved left");
        }
        if (Input.GetAxis("Mouse X") < 0)
        {
            //Code for action on mouse moving right
            body.AddForce(new Vector3(-5, 0, 0), ForceMode.Force);
            print("Mouse moved right");
        }
        */


    }
    public void Right()
    {
        body.AddForce(new Vector3(30, 0, 0), ForceMode.Acceleration);   
    }

    public void Left()
    {
        body.AddForce(new Vector3(-30, 0, 0), ForceMode.Acceleration);
    }


    public void OnTriggerEnter2D(Collider2D collision)
     {
         if(collision.CompareTag("Death"))
         {
             Debug.Log("Done");
            // panel.SetActive(true);
         }
     }
}
