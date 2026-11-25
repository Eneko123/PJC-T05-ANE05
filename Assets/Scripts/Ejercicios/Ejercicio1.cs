using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class Ejercicio1 : MonoBehaviour
{
    private float[] numeros;
    private int n = 1000000;

    void Start()
    {
        numeros = new float[n];
        for (int i = 0; i < n; i++)
        {
            numeros[i] = i;
        }
    }

    private void On_01(InputValue value)
    {
        if (value.isPressed)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Suma(i);
                RaizCuadrada(i);
                Coseno(i);
                Seno(i);
            }
            Debug.Log("Boton 1 presionado");
        }
    }

    private void Suma(int i)
    {
        i += i;
    }

    private void RaizCuadrada(float i)
    {
        float x;
        x = Mathf.Sqrt(i);
    }

    private void Coseno(float i)
    {
        float x;
        x = Mathf.Cos(i);
    }

    private void Seno(float i)
    {
        float x;
        x = Mathf.Sin(i);
    }
}
