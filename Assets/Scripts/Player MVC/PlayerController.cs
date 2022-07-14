using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController 
{
    PlayerView playerView;
    PlayerModel playerModel;

    public PlayerController( PlayerView playerView, PlayerModel playerModel)
    {
        this.playerView = playerView;
        this.playerView.SetPlayerControllerReference(this);
        this.playerModel = playerModel;
    }

    public void Movement()
    {
        if(playerView._controller.isGrounded)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            playerModel.direction = new Vector3(horizontal, 0, vertical);
            playerModel.direction *= playerModel.speed;

            if(Input.GetKeyDown(KeyCode.Space))
            {
                playerModel.direction.y = playerModel.jumpHeight;
            }
        }

        playerModel.direction.y -= playerModel.gravityValue * Time.deltaTime;
        playerView._controller.Move(playerModel.direction * Time.deltaTime);
    }
}
