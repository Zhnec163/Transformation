using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    private Vector3 _direction;
    private float _speed = 1F;
    
    private void Update()
    {
        Move();
    }

    public void Init(Vector3 direction)
    {
        _direction = direction;
    }

    private void Move()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }
}
