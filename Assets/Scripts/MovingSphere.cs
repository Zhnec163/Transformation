using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSphere : MonoBehaviour
{
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        var nextPosition = transform.position;
        nextPosition.x += 0.05F;
        transform.position = nextPosition;
    }
}
