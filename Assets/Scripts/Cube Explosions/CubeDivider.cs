using UnityEngine;
using Random = UnityEngine.Random;

public class CubeDivider : MonoBehaviour
{
    [SerializeField] private int _scaleDivider = 2;
    [SerializeField] private int _chanceDivider = 2;      
    [SerializeField] private int _divisionChance = 100;

    public void Divide()
    {
        int minPercent = 0;
        int maxPercent = 100;
        int randomValue = Random.Range(minPercent, maxPercent);
        
        if (randomValue < _divisionChance)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            SetRandomColor(cube.GetComponent<Renderer>().material);
            cube.transform.position = transform.position;
            cube.transform.localScale = transform.localScale / _scaleDivider;
            cube.AddComponent(typeof(Rigidbody));
            cube.AddComponent(typeof(CubeDivider));
            CubeDivider cubeDivider = cube.GetComponent<CubeDivider>();
            cubeDivider._divisionChance /= _chanceDivider;
            cubeDivider.Divide();
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