using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    //Start is called before the first frame update
    private void Start()
    {
        Second();
    }

    //// Update is called once per frame
    private void Update()
    {
        Fourth();
    }

    private void OnValidate()
    {
        Third();
    }

    private void First()
    {
        int a = 1;
        long l = 2l;
        float f = 2.123444444422433f;
        double d = 2.123444444422433d;
        decimal m = 2.123444444422433m;
        bool b = true;
        char c = 'k';
        string s = "Artem";

        l = a;
        a = (int)l;

        Debug.Log(a);
        Debug.LogError(l);
        Debug.LogError(f);
        Debug.LogError(d);
        Debug.LogError(m);
        Debug.LogError(b);
        Debug.LogError(c);
        Debug.LogError(s);
    }

    private void Second()
    {
        float health = 99.555f;

        Debug.LogWarning(message: string.Format("Player {0:C0} health {1}", health, 6));
        Debug.LogWarning(message: $"Player {health:##.##} health");
    }

    public string A;
    public string B;
    public string Result;
    private void Third()
    {
        //=
        int a = 7;

        //+ - * /
        int intA = int.Parse(A);
        int intB = int.Parse(B);
        Result = (intA + intB).ToString();

        // /
        double doubleA = double.Parse(A);
        double doubleB = double.Parse(B);
        Result = (doubleA / doubleB).ToString();

        // ++ --
        int i = 5;
        i = i + 1;
        i += 1;

        int j = 8;
        Debug.LogError(j++);
        Debug.LogError(++j);
    }
    public float D;
    public float E;
    public float Result2;
    private int[] _array = { 1, 2, 3, 4, 5 };
    private int _currentIndex = 0;
    private void Fourth()
    {
        // %
        Result2 = D % E;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _currentIndex++;
            int index = _currentIndex % _array.Length;
            Debug.LogError(_array[index]);
            Debug.LogWarning(index);
            Debug.LogWarning(_currentIndex);
        }
    }

}
