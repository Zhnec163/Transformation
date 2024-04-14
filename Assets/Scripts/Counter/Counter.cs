using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(ClickHandler))]
public class Counter : MonoBehaviour
{
    private ClickHandler _clickHandler;
    private int _count;
    private bool _counterRun;

    private void Awake()
    {
        _clickHandler = GetComponent<ClickHandler>();
    }

    private void ProcessClick()
    {
        _counterRun = !_counterRun;
            
        if (_counterRun)
        {
            StartCoroutine(IncrementCounter());
        }
    }   
    
    private IEnumerator IncrementCounter()
    {
        while (_counterRun)
        {
            _count++;
            Debug.Log(_count);
            yield return null;
        }
    }
    
    private void OnEnable()
    {
        _clickHandler.Click += ProcessClick;
    }

    private void OnDisable()
    {
        _clickHandler.Click -= ProcessClick;
    }
}
