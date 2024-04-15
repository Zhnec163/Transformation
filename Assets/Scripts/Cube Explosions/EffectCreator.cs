using System.Collections.Generic;
using UnityEngine;

public class EffectCreator : MonoBehaviour
{
    private float _explosionRadius = 3;
    private float _explosionForce = 500;
    
    public void CreateAnExplosionEffect(Vector3 position)
    {
        foreach (Rigidbody explodableObject in GetExplodableObjects(position))
        {
            explodableObject.AddExplosionForce(_explosionForce, position, _explosionRadius);
        }
    }

    private List<Rigidbody> GetExplodableObjects(Vector3 position)
    {
        Collider[] hits = Physics.OverlapSphere(position, _explosionRadius);
        List<Rigidbody> objects = new();

        foreach (Collider hit in hits)
        {
            if (hit.attachedRigidbody != null)
            {
                objects.Add(hit.attachedRigidbody);
            }
        }

        return objects;
    }
}
