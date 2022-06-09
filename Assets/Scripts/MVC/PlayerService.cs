using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerService : SingletonGeneric<PlayerService>
{
    [SerializeField]
    PlayerView playerView;
    [SerializeField]
    PlayerView playerView2;

    [SerializeField]
    PlayerSO playerSO;
    [SerializeField]
    PlayerSO playerSO2;


    public PlayerController playerController;

    void Start()
    {
        CreatePlayer();
    }

    private void CreatePlayer()
    {
        PlayerModel playerModel = new PlayerModel(playerSO);
        PlayerModel playerModel2 = new PlayerModel(playerSO2);

        playerController = new PlayerController(playerView, playerModel);
        playerController = new PlayerController(playerView2, playerModel2);
    }
}
