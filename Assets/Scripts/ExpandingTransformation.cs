using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandingTransformation : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void FixedUpdate()
    {
        Expand();
    }

    private void Expand()
    {
        Vector3 nextScale = new Vector3(transform.localScale.x + _speed,  transform.localScale.y + _speed, transform.localScale.z + _speed);
        transform.localScale = nextScale;
    }
}
