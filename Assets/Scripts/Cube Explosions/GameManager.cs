using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private CubesCreator _cubesCreator = new ();
    [SerializeField] private InputHandler _inputHandler = new ();
    
    private EffectCreator _effectCreator = new ();

    private void OnEnable()
    {
        _inputHandler.Click += ExplodeGeneratedCubes;
    }

    private void OnDisable()
    {
        _inputHandler.Click -= ExplodeGeneratedCubes;
    }

    private void ExplodeGeneratedCubes(Transform coordinate)
    {
        _cubesCreator.CreateCubes(coordinate);
        _effectCreator.CreateAnExplosionEffect(coordinate.position);
    }
}
