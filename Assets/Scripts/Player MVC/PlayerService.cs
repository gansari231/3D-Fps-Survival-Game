using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerService : GenericSingleton<PlayerService>
{
    [SerializeField]
    PlayerView playerView;
    PlayerModel playerModel;
    
    void Start()
    {
        SpawnPlayer();
    }

    void SpawnPlayer()
    {
        playerModel = new PlayerModel();
        PlayerController playerController = new PlayerController(playerView, playerModel);
    }
}
