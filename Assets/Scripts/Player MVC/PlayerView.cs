using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    PlayerController playerController;

    CharacterController controller;
    public CharacterController _controller { get { return controller; } }

    public void SetPlayerControllerReference(PlayerController playerController)
    {
        this.playerController = playerController;
    }

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        playerController.Movement();
    }
}
