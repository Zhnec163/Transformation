using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    
    private int _timeStep = 2;
    private bool _isWork = true;
    
    private void Start()
    {
        StartCoroutine(GenerateEnemies());
    }

    private IEnumerator GenerateEnemies()
    {
        while (_isWork)
        {
            GameObject enemyGameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
            enemyGameObject.transform.position = transform.position;
            enemyGameObject.transform.rotation = transform.rotation;
            enemyGameObject.AddComponent<EnemyMover>();
            EnemyMover enemyMover = enemyGameObject.GetComponent<EnemyMover>();
            enemyMover.SetDirection(_direction.normalized);
            yield return new WaitForSeconds(_timeStep);
        }
    }
}
