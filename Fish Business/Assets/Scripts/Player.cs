using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    public float speed = 5f;

    Rigidbody player_rb;

    // Start is called before the first frame update
    void Start()
    {
        player_rb = GetComponent<Rigidbody>();
    }//ends Start

    // Update is called once per frame
    void Update()
    {


        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        player_rb.velocity = new Vector3(xMov*speed, player_rb.velocity.y, zMov *speed) *Time.deltaTime;


        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -1, 0);
        }
  
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 1, 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {

        }
      
    
        }//ends Update

    }//ends public class

