using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSO", menuName = "Scriplables/NewPlayer")]
public class PlayerSO : ScriptableObject
{
    public PlayerView playerView;
    public float Speed;
    public float jumpHeight;
    public float gravityScale;
    public float moveDirection;
    public bool isGrounded;
    public bool isfacingRight;
}
