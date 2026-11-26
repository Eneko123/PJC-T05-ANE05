using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ejercicio3 : MonoBehaviour
{
    private float[] numeros;
    private int n = 1000000;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numeros = new float[n];
        for (int i = 0; i < n; i++)
        {
            numeros[i] = i;
        }
    }

    private void On_03(InputValue value)
    {
        if (value.isPressed)
        {
            DoTask(5);
            Debug.Log("Boton 3 presionado");
        }
    }

    private async Task DoTask(int wait)
    {
        Exercise();
        Debug.Log("Primera tarea terminada");
        await Task.Delay(wait);
        Exercise();
        Exercise();
        Debug.Log("Segunda tarea terminada");
        await Task.CompletedTask;
    }

    private void Exercise()
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            Suma(i);
            RaizCuadrada(i);
            Coseno(i);
            Seno(i);
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
