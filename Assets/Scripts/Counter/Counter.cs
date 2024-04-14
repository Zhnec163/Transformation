using System.Collections;
using UnityEngine;

[RequireComponent(typeof(ClickHandler))]
public class Counter : MonoBehaviour
{
    private ClickHandler _clickHandler;
    private float _count;
    private bool _counterRun;
    private float _timeStep = 0.5F;
    private IEnumerator _currenCoroutine;

    private void Awake()
    {
        _clickHandler = GetComponent<ClickHandler>();
    }

    private void ProcessClick()
    {
        _counterRun = !_counterRun;
            
        if (_counterRun)
        {
            _currenCoroutine = IncrementCounter();
            StartCoroutine(_currenCoroutine);
        }
        else
        {
            StopCoroutine(_currenCoroutine);
        }
    }   
    
    private IEnumerator IncrementCounter()
    {
        while (_counterRun)
        {
            yield return new WaitForSeconds(_timeStep);
            _count++;
            Debug.Log(_count);
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
