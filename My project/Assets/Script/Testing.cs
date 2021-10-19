using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField]
    private float _seconds = 4;

    [SerializeField]
    private float _secondUP = 1;

    [SerializeField]
    private float _secStop = 30;

    private Coroutine _printHello;

    private ButtonMouse getAnyKey;

    // Start is called before the first frame update
    private void Start()
    {
        _printHello = StartCoroutine(PrintHello(_seconds));
        StartCoroutine(CountUp(_secondUP, _secStop));
        StartCoroutine(BeingPressed());
    }

    /// <summary>
    /// TO be able to print our text in x seconds
    /// </summary>
    /// <param name="seconds"></param>
    /// <returns></returns>
    private IEnumerator PrintHello(float seconds) 
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(seconds);

        while (true)
        {
            Debug.Log("Hello");

            yield return waitForSeconds;
        }  
    }

    private IEnumerator CountUp(float seconds, float secsStopHello) 
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(seconds);

        int count = 0;
        while (true)
        {
            Debug.Log(count);
            count++;

            if (count == _secStop)
            {
                StopCoroutine(_printHello);
            }

            yield return waitForSeconds;
        }
    }

    private IEnumerator BeingPressed() 
    {
        ButtonMouse wfp = new ButtonMouse();
        while (true)
        {
            yield return wfp;
            Debug.Log($"Estou a ser pressionado");
        }

        
    }
}
