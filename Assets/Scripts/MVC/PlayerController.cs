using UnityEngine;

public class PlayerController
{
    public PlayerModel playerModel;
    PlayerView playerView;
    Transform t;
    BoxCollider2D mainCollider;

    public PlayerController(PlayerView _playerView, PlayerModel _playerModel)
    {
        playerView = GameObject.Instantiate(_playerView);
        playerModel = _playerModel;
        playerView.SetPlayerController(this);
    }
    public void movementcontrols()
    {

        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) && (playerModel.isGrounded || Mathf.Abs(playerView.rigidbody2d.velocity.x) > 0.01f))
        {
            playerModel.moveDirection = Input.GetKey(KeyCode.A) ? -1 : 1;
        }
        else
        {
            if (playerModel.isGrounded)
            {
                playerModel.moveDirection = 0;

            }
        }
    }
    public void Jumping()
    {
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)) && Mathf.Abs(playerView.rigidbody2d.velocity.y) < 0.01f)
        {
            playerView.rigidbody2d.velocity = new Vector2(playerView.rigidbody2d.velocity.x, playerModel.jumpHeight);
            playerView.SetJumpTrue();
        }
        else
        {
            playerView.SetJumpFalse();
        }
    }
    private void FixedUpdate()
    {
        Bounds colliderBounds = mainCollider.bounds;
        float colliderRadius = mainCollider.size.x * 0.4f * Mathf.Abs(playerView.transform.localScale.x);
        Vector3 groundCheckPos = colliderBounds.min + new Vector3(colliderBounds.size.x * 0.5f, colliderRadius * 0.9f, 0);
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckPos, colliderRadius);
        playerModel.isGrounded = false;
        if (colliders.Length > 0)
        {
            for (int i = 0; i < colliders.Length; i++)
            {
                if (colliders[i] != mainCollider)
                {
                    playerModel.isGrounded = true;
                    break;
                }
            }
        }
    }

}
