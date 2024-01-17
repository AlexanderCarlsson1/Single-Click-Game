using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject ballPos;
    public GameObject cameraPos;

    // Update is called once per frame
    void Update()
    {
        cameraPos.transform.position = new Vector3(ballPos.transform.position.x, ballPos.transform.position.y, -10);
    }
}
