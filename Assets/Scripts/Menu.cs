using UnityEngine;

public class Menu : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public string scene;
    float vertical;
    Rigidbody2D body;
    public float runSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        {
            body.velocity = new Vector2(0, vertical * runSpeed);
        }
    }



}