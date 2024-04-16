using UnityEngine;

[RequireComponent(typeof(CubeDivider), typeof(EffectCreator))]
public class QuantumCube : MonoBehaviour
{
    private EffectCreator _effectCreator;
    private CubeDivider _cubeDivider;

    private void Awake()
    {
        _cubeDivider = GetComponent<CubeDivider>();
        _effectCreator = GetComponent<EffectCreator>();
    }

    public void StartDivision()
    {
        _cubeDivider.Divide();
        _effectCreator.CreateAnExplosionEffect(transform.position);
        Destroy(gameObject);
    }
}
