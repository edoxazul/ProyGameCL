using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Management : MonoBehaviour
{
    private int score = 0;
    private int firstDigit = 0;
    private int secondDigit = 0;
    private int thirdDigit = 0;
    private int guantes = 0;
    private int mascarillas = 0;
    private ScoreNumber ui_d1;
    private ScoreNumber ui_d2;
    private ScoreNumber ui_d3;
    // Start is called before the first frame update
    void Start()
    {
        ui_d1 = GameObject.Find("ui_d1").GetComponent<ScoreNumber>();
        ui_d2 = GameObject.Find("ui_d2").GetComponent<ScoreNumber>();
        ui_d3 = GameObject.Find("ui_d3").GetComponent<ScoreNumber>();
    }
    public void AddScore(int number)
    {
        score = score + number;
        if (score > 999)
        {
            score = 999;
        }
        firstDigit = score / 100;
        secondDigit = score / 10 - firstDigit * 10;
        thirdDigit = score - secondDigit * 10 - firstDigit * 100;
        ui_d1.UpdateTexture(firstDigit);
        ui_d2.UpdateTexture(secondDigit);
        ui_d3.UpdateTexture(thirdDigit);
    }
    public void AddGuante()
    {
        guantes = guantes++;
    }
    public void AddMascarilla()
    {
        mascarillas = mascarillas++;
    }
    public void SubtractGuante(int number)
    {
        guantes = guantes - number;
    }
    public void SubtractMascarilla(int number)
    {
        mascarillas = mascarillas - number;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
