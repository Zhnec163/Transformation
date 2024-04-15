using UnityEngine;

public class CubesCreator : MonoBehaviour
{
    [SerializeField] private int _maxCubesWhenDividing = 6;
    [SerializeField] private int _scaleDivider = 2;
    [SerializeField] private int _chanceDivider = 2;

    public void CreateCubes(Transform originalCube)
    {
        int cubesCount = 1;
        int currentDivisionChance = 100;
        int minPercent = 0;
        int maxPercent = 100;
        int randomValue = Random.Range(minPercent, maxPercent);
        Vector3 currentScale = originalCube.localScale / _scaleDivider;
        
        Destroy(originalCube.gameObject);
        CreateRandomColorCube(originalCube.position, currentScale);
        currentScale /= _scaleDivider;

        while (randomValue < currentDivisionChance && cubesCount <= _maxCubesWhenDividing)
        {
            CreateRandomColorCube(originalCube.position, currentScale);
            cubesCount++;
            currentScale /= _scaleDivider;
            currentDivisionChance /= _chanceDivider;
        }
    }

    private void CreateRandomColorCube(Vector3 position, Vector3 scale)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = position;
        cube.transform.localScale = scale;
        SetRandomColor(cube.GetComponent<Renderer>().material);
        AddGravity(cube);
    }

    private void AddGravity(GameObject cube)
    {
        cube.AddComponent<Rigidbody>();
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