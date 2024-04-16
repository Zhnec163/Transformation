using UnityEngine;

public class QuantumCubeClickHandler : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    private Ray _ray;

    private void Update()
    {
        _ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            
            if (Physics.Raycast(_ray, out hit, Mathf.Infinity))
            {
                hit.transform.GetComponent<QuantumCube>().StartDivision();
            }
        }
    }
}