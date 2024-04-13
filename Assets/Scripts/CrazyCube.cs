using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyCube : MonoBehaviour
{
    private float _rotateSpeed = 0.05F;
    private float _expandSpeed = 0.005F;

    private void FixedUpdate()
    {
        Move();
        Rotate();
        Expand();
    }

    private void Move()
    {
        var nextPosition = transform.position;
        nextPosition.x += 0.05F;
        transform.position = nextPosition;
    }

    private void Rotate()
    {
        Vector3 nextVector = new Vector3(transform.rotation.x, _rotateSpeed, transform.rotation.z);
        transform.Rotate(nextVector);
    }

    private void Expand()
    {
        Vector3 nextScale = new Vector3(transform.localScale.x + _expandSpeed, transform.localScale.y + _expandSpeed,
            transform.localScale.z + _expandSpeed);
        transform.localScale = nextScale;
    }
}