using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girar : MonoBehaviour
{
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);
        time = time + Time.deltaTime;
        if (time > 2)
        {
            transform.Rotate(new Vector3(0, 180, 0));
            time = 0;
        }
    }
}
