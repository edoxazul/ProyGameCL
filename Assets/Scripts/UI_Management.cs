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
    private ScoreNumber ui_p1;
    private ScoreNumber ui_p2;
    private ScoreNumber ui_p3;
    private ScoreNumber ui_g;
    private ScoreNumber ui_m;
    // Start is called before the first frame update
    void Start()
    {
        ui_p1 = GameObject.Find("ui_p1").GetComponent<ScoreNumber>();
        ui_p2 = GameObject.Find("ui_p2").GetComponent<ScoreNumber>();
        ui_p3 = GameObject.Find("ui_p3").GetComponent<ScoreNumber>();
        ui_g = GameObject.Find("ui_g").GetComponent<ScoreNumber>();
        ui_m = GameObject.Find("ui_m").GetComponent<ScoreNumber>();
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
        ui_p1.UpdateTexture(firstDigit);
        ui_p2.UpdateTexture(secondDigit);
        ui_p3.UpdateTexture(thirdDigit);
    }
    public void AddGuante()
    {
        guantes++;
        if (guantes > 9)
        {
            guantes = 9;
        }
        ui_g.UpdateTexture(guantes);
    }
    public void AddMascarilla()
    {
        mascarillas++;
        if (mascarillas > 9)
        {
            mascarillas = 9;
        }
        ui_m.UpdateTexture(mascarillas);
    }
    public void SubtractGuante(int number)
    {
        guantes = guantes - number;
        ui_g.UpdateTexture(guantes);
    }
    public void SubtractMascarilla(int number)
    {
        mascarillas = mascarillas - number;
        ui_m.UpdateTexture(mascarillas);
    }
}
