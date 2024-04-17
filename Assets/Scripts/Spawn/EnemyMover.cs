using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    private Vector3 _direction;
    private float _speed = 1F;

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }
}
