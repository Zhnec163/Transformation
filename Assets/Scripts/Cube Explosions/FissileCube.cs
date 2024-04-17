using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(EffectCreator))]
public class FissileCube : MonoBehaviour
{
    [SerializeField] private FissileCube _fissileCube;
    [SerializeField] private int _mimCubesWhenDividing = 2;
    [SerializeField] private int _maxCubesWhenDividing = 7;
    [SerializeField] private int _scaleDivider = 2;
    [SerializeField] private int _chanceDivider = 2;      
    [SerializeField] private int _divisionChance = 100;
    
    private EffectCreator _effectCreator;

    private void Awake()
    {
        _effectCreator = GetComponent<EffectCreator>();
    }

    public void ProcessClick()
    {
        Divide();
    }

    public void Init(int divisionChance, Vector3 scale, Color color)
    {
        _divisionChance = divisionChance;
        transform.localScale = scale;
        
        if (TryGetComponent<Renderer>(out Renderer renderer))
        {
            renderer.material.color = color;
        }
    }

    private void Divide()
    {
        int minPercent = 0;
        int maxPercent = 100;
        int randomValue = RandomHelper.GetRandomNumber(minPercent, maxPercent);
        List<Rigidbody> rigidbodies = new List<Rigidbody>();

        if (randomValue < _divisionChance)
        {
            int cubesCount = RandomHelper.GetRandomNumber(_mimCubesWhenDividing, _maxCubesWhenDividing);

            for (int i = 0; i < cubesCount; i++)
            {
                FissileCube fissileCube = InstantiateFissileCube();

                if (fissileCube.TryGetComponent<Rigidbody>(out Rigidbody rigidbody))
                {
                    rigidbodies.Add(rigidbody);
                }
            }

            _effectCreator.CreateAnExplosionEffect(transform.position, rigidbodies);
        }

        Destroy(gameObject);
    }

    private FissileCube InstantiateFissileCube()
    {
        FissileCube fissileCube = Instantiate(this._fissileCube, transform.position, Quaternion.identity);
        int chance = _divisionChance / _chanceDivider;
        Vector3 scale = transform.localScale / _scaleDivider;
        fissileCube.Init(chance, scale, RandomHelper.GetRandomColor());
        return fissileCube;
    }
}
