using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private GameObject _enemy;
    
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
            GameObject enemy = Instantiate(_enemy, transform.position, Quaternion.identity);
            EnemyMover enemyMover = enemy.GetComponent<EnemyMover>();
            enemyMover.SetDirection(_direction.normalized);
            yield return new WaitForSeconds(_timeStep);
        }
    }
}
