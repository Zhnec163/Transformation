using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomHelper : MonoBehaviour
{
    public static int GetRandomNumber(int min, int max)
    {
        return Random.Range(min, max);
    }
    
    public static Color GetRandomColor()
    {
        int r = Random.Range(0, 255);
        int g = Random.Range(0, 255);
        int b = Random.Range(0, 255);
        int alpha = 1;
        return new Color(r, g, b, alpha);
    }
}
