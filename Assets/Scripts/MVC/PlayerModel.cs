using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    private PlayerController playerController;
    public float Speed { get; }
    public float jumpHeight { get; }
    public float gravityScale { get; }
    public float moveDirection { get; set; }
    public bool isGrounded { get; set; }
    public bool isfacingRight { get; set; } = true;


    public PlayerModel(PlayerSO playerSO)
    {
        Speed = playerSO.Speed;
        jumpHeight = playerSO.jumpHeight;
        gravityScale = playerSO.gravityScale;
        moveDirection = playerSO.moveDirection;
        isGrounded = playerSO.isGrounded;
        isfacingRight = playerSO.isfacingRight;
    }
    private void setPlayerController(PlayerController _playerController)
    {
        playerController = _playerController;
    }

}
