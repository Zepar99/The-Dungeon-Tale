using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    protected Vector3 velocity;
    public Transform _transform;
    public float distance = 5f;
    public float speed = 1f;
    Vector3 _originalPosition;
    bool isGoingUp = false;
    public float distFromStart;
    public void Start()
    {
        _originalPosition = gameObject.transform.position;
        _transform = GetComponent<Transform>();
        velocity = new Vector3(0, speed, 0);
        _transform.Translate(0, velocity.y * Time.deltaTime, 0);

    }

    void Update()
    {
        distFromStart = transform.position.y - _originalPosition.y;

        if (isGoingUp)
        {

            if (distFromStart < -distance)
                SwitchDirection();

            _transform.Translate(0, velocity.y * Time.deltaTime, 0);
            transform.Rotate(new Vector2(0.0f, 0.0f));
        }
        else
        {

            if (distFromStart > distance)
                SwitchDirection();

            _transform.Translate(0, velocity.y * Time.deltaTime, 0);
        }

        void SwitchDirection()
        {
            isGoingUp = !isGoingUp;
            transform.Rotate(new Vector2(180.0f, 0.0f));
        }

    }
}
