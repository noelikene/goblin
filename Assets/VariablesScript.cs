using UnityEngine;

public class VariablesScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello world");

        int age = 41;
        float height = 1.71f;
        string name = "Noel";
        bool isStudent = true;

        Debug.Log("Age:" + age);



    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update world");
    }
}