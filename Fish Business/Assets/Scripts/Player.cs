using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    int player_x_coordinate = 0;
    int player_y_coordinate = 0;
    int player_z_coordinate = 0;

    // Start is called before the first frame update
    void Start()
    {
        print("Me Play");
        transform.localPosition = new Vector3(player_x_coordinate, player_y_coordinate, player_z_coordinate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
