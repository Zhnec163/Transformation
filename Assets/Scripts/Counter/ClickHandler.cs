using System;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    public event Action Click;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Click.Invoke();
        }
    }
}
