using UnityEngine;
using TMPro;

public class CanvasExampleScript : MonoBehaviour
{
    public TextMeshProUGUI nameFieldText;
    public TextMeshProUGUI numberText;


    void Start()
    {
        string name = "Erik";
        nameFieldText.text = name;
    }

    public void NameChanger()
    {
        Debug.Log("Küpsis");
        nameFieldText.text = "Küpsis";
    }

    public void IncreaseNumber()
    {
        int number = 0;
        number++;
        numberText.text = number.ToString();
    }




}
