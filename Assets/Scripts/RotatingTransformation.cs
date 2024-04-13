using UnityEngine;

public class RotatingTransformation : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void FixedUpdate()
    {
        Rotate();
    }

    private void Rotate()
    {
        Vector3 nextVector = new Vector3(transform.rotation.x, _speed, transform.rotation.z);
        transform.Rotate(nextVector);
    }
}
