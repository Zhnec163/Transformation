using System.Collections.Generic;
using UnityEngine;

public class EffectCreator : MonoBehaviour
{
    private float _explosionRadius = 3;
    private float _explosionForce = 500;
    
    public void CreateAnExplosionEffect(Vector3 position, List<Rigidbody> objects)
    {
        foreach (Rigidbody explodableObject in objects)
        {
            explodableObject.AddExplosionForce(_explosionForce, position, _explosionRadius);
        }
    }
}
