using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    int player_x_coordinate = 0;
    int player_y_coordinate = 5;
    int player_z_coordinate = 0;

    int Playerspeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = new Vector3(player_x_coordinate, player_y_coordinate, player_z_coordinate);
    }

    // Update is called once per frame
    void Update()
    {
        //Go Forward and Backwards. Z Is forward and backwards.
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0, 0, Playerspeed);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -Playerspeed);
        }
        //Go Left and Right
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, Playerspeed, 0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, -Playerspeed, 0);
        }

        

    }

    
}
