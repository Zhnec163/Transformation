using UnityEngine;

[RequireComponent(typeof(EffectCreator))]
public class QuantumCube : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    
    private EffectCreator _effectCreator;

    private void Awake()
    {
        _effectCreator = GetComponent<EffectCreator>();
    }

    public void ProcessClick()
    {
        Destroy(gameObject);
        Instantiate(_cube, transform.position, Quaternion.identity);
        _effectCreator.CreateAnExplosionEffect(transform.position);
    }
}
