using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private EnemyMover _enemyMover;
    
    private int _timeStep = 2;
    private bool _isWork = true;
    
    private void Start()
    {
        StartCoroutine(GenerateEnemies());
    }

    private IEnumerator GenerateEnemies()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(_timeStep);
        
        while (_isWork)
        {
            EnemyMover enemyMover = Instantiate(_enemyMover, transform.position, Quaternion.identity);
            enemyMover.Init(_direction.normalized);
            yield return waitForSeconds;
        }
    }
}
