using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private float timeLeft = 1;
    public float speed = 2f;
    public Rigidbody2D rb;

    public Vector2 minPower;
    public Vector2 maxPower;

    Camera cam;
    Vector2 force;
    Vector3 start;
    Vector3 end;

    public void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            start = cam.ScreenToWorldPoint(Input.mousePosition);
            start.z = 15;
            Debug.Log(start);
        }
        if (Input.GetMouseButtonUp(0))
        {
            end = cam.ScreenToWorldPoint(Input.mousePosition);
            end.z = 15;
            Debug.Log(end);

            force = new Vector2(Mathf.Clamp(start.x - end.x, minPower.x, maxPower.x), Mathf.Clamp(start.y - end.y, minPower.y, maxPower.y));
            rb.AddForce(force * speed, ForceMode2D.Impulse);

        }
        timeLeft -= Time.deltaTime;
       if (timeLeft <= 0)
       {
           // maxPower = maxPower - 1; 
         //   if (maxPower == 0)
          //  {
                //maxPower = 2;
          //  }
            //Rigidbody.MovePosition(lastVelocity);
        }
    }
    private void funTime()
    {

    }
}
