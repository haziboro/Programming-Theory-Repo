using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ClickerController : MonoBehaviour
{
    public static ClickerController instance { get; private set; }

    public float clickerPower { get; private set; }
    public Camera mainCamera;

    [SerializeField] Button lowPower;
    [SerializeField] Button mediumPower;
    [SerializeField] Button highPower;

    // Start is called before the first frame update
    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        lowPower.onClick.AddListener(LowPower);
        mediumPower.onClick.AddListener(MediumPower);
        highPower.onClick.AddListener(HighPower);

        LowPower();
    }


    void LowPower()
    {
        SetColor(lowPower);
        RestoreOtherButtonsColors(mediumPower, highPower);
        clickerPower = 1;
    }

    void MediumPower()
    {
        SetColor(mediumPower);
        RestoreOtherButtonsColors(lowPower, highPower);
        clickerPower = 5;
    }

    void HighPower()
    {
        SetColor(highPower);
        RestoreOtherButtonsColors(lowPower, mediumPower);
        clickerPower = 20;
    }

    //Visually makes the other buttons appear inactive
    void RestoreOtherButtonsColors(Button first, Button second)
    {
        first.GetComponent<Image>().color = Color.white;
        second.GetComponent<Image>().color = Color.white;
    }
    void SetColor(Button buttonToChange)
    {
        buttonToChange.GetComponent<Image>().color = Color.black;
    }
}
