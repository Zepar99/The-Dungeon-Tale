using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    PlayerController playerController;

    public Rigidbody2D rigidbody2d;
    [SerializeField]
    Animator animator;
    Transform t;

    public void SetPlayerController(PlayerController _playerController)
    {
        playerController = _playerController;
    }
    private void Awake()
    {
        GmaeStateManager.Instance.OnGameStateChanged += OnGameStateChanged;
    }
    private void OnDestroy()
    {
        GmaeStateManager.Instance.OnGameStateChanged -= OnGameStateChanged;
    }
    void Start()
    {
        t = transform;
        rigidbody2d = GetComponent<Rigidbody2D>();
        playerController.mainCollider = GetComponent<BoxCollider2D>();
        rigidbody2d.freezeRotation = true;
        rigidbody2d.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        rigidbody2d.gravityScale = playerController.playerModel.gravityScale;
        playerController.playerModel.isfacingRight = t.localScale.x > 0;
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
        animator.SetFloat("Speed", (Mathf.Abs(playerController.playerModel.moveDirection)));
        playerController.Jumping();
        rigidbody2d.velocity = new Vector2((playerController.playerModel.moveDirection) * playerController.playerModel.Speed, rigidbody2d.velocity.y);
    }

    private void OnGameStateChanged(GameState newGameState)
    {
        enabled = newGameState == GameState.Gameplay;
    }
}
