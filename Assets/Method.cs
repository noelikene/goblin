using UnityEngine;

public class Method : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SayHelloTo("Mark", "Joosep");

        CalculateSquareArea(4);
        Debug.Log(CalculateTriangleArea(3,6));
    }

    private void SayHelloTo(string name1, string name2)
    {
        Debug.Log("Hello " + name1);
        Debug.Log("Hello " + name2);    
    }


    private float CalculateSquareArea(float a)
    {
        float area = a*a;
        Debug.Log("Kui ruudu külje pikkus on " + a + ", siis ruudu pindala on " + area);
        return area;
    }

    private int CalculateTriangleArea(int alus, int h)
    {
        int trianglearea = alus*h/2;
        Debug.Log("Kui kolmnurga alus on " + alus + " ja kõrgus on " + h + ", siis kolmurga pindala on " + trianglearea);
        return trianglearea;
    }
}
