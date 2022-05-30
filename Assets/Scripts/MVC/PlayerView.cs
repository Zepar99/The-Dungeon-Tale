using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    PlayerController playerController;

    public Rigidbody2D rigidbody2d;
    [SerializeField]
    Animator animator;

    public void SetPlayerController(PlayerController _playerController)
    {
        playerController = _playerController;
    }
    public void SetJumpTrue()
    {
        animator.SetBool("Jump", true);
    }
    public void SetJumpFalse()
    {
        animator.SetBool("Jump", false);
    }
    void Update()
    {
        playerController.movementcontrols();
        playerController.Jumping();
        rigidbody2d.velocity = new Vector2((playerController.playerModel.moveDirection) * playerController.playerModel.Speed, rigidbody2d.velocity.y);
    }

}
