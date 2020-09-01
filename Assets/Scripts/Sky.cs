using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine.SceneManagement;

public class Sky : MonoBehaviour
{
    Transform thisTransform;
    Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        thisTransform = GameObject.Find("Sky").GetComponent<Transform>();
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("Sky").GetComponent<Transform>().position = new Vector3(playerTransform.position.x,10 + (playerTransform.position.z / 10), playerTransform.position.z - (playerTransform.position.z / 30) + 100);
    }
}
