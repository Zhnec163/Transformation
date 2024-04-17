using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class CubeDivider : MonoBehaviour
{
    [SerializeField] private int _scaleDivider = 2;
    [SerializeField] private int _chanceDivider = 2;      
    [SerializeField] private int _divisionChance = 100;
    [SerializeField] private GameObject _cube;

    private void Start()
    {
        int minPercent = 0;
        int maxPercent = 100;
        int randomValue = Random.Range(minPercent, maxPercent);
        
        if (randomValue < _divisionChance)
        {
            GameObject cube = Instantiate(_cube, transform.position, Quaternion.identity);
            SetRandomColor(cube.GetComponent<Renderer>().material);
            cube.transform.localScale = transform.localScale / _scaleDivider;
            CubeDivider cubeDivider = cube.GetComponent<CubeDivider>();
            cubeDivider._divisionChance /= _chanceDivider;
        }
    }
    
    private void SetRandomColor(Material material)
    {
        int r = Random.Range(0, 255);
        int g = Random.Range(0, 255);
        int b = Random.Range(0, 255);
        int alpha = 1;
        material.color = new Color(r, g, b, alpha);
    }
}