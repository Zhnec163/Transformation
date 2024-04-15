using System;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public event Action<Transform> Click;
    
    [SerializeField] private Camera _camera;

    private Ray _ray;

    void Update()
    {
        _ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            
            if (Physics.Raycast(_ray, out hit, Mathf.Infinity))
            {
                Click.Invoke(hit.transform);
            }
        }
    }
}