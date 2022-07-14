using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel 
{
    public float speed;
    public float gravityValue;
    public float jumpHeight;
    public Vector3 direction;

    public PlayerModel()
    {
        speed = 5f;
        gravityValue = 20f;
        jumpHeight = 10f;
        direction = Vector3.zero;
    }
}
