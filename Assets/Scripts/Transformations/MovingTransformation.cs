using UnityEngine;

public class MovingTransformation : MonoBehaviour
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
