using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreNumber : MonoBehaviour
{
    public Texture texture0;
    public Texture texture1;
    public Texture texture2;
    public Texture texture3;
    public Texture texture4;
    public Texture texture5;
    public Texture texture6;
    public Texture texture7;
    public Texture texture8;
    public Texture texture9;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<RawImage>().texture = texture0;
    }
    public void UpdateTexture(int number)
    {
        if (number == 0)
        {
            this.gameObject.GetComponent<RawImage>().texture = texture0;
        }
        if (number == 1)
        {
            this.gameObject.GetComponent<RawImage>().texture = texture1;
        }
        if (number == 2)
        {
            this.gameObject.GetComponent<RawImage>().texture = texture2;
        }
        if (number == 3)
        {
            this.gameObject.GetComponent<RawImage>().texture = texture3;
        }
        if (number == 4)
        {
            this.gameObject.GetComponent<RawImage>().texture = texture4;
        }
        if (number == 5)
        {
            this.gameObject.GetComponent<RawImage>().texture = texture5;
        }
        if (number == 6)
        {
            this.gameObject.GetComponent<RawImage>().texture = texture6;
        }
        if (number == 7)
        {
            this.gameObject.GetComponent<RawImage>().texture = texture7;
        }
        if (number == 8)
        {
            this.gameObject.GetComponent<RawImage>().texture = texture8;
        }
        if (number == 9)
        {
            this.gameObject.GetComponent<RawImage>().texture = texture9;
        }
    }
}
