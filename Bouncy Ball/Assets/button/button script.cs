using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonscript : MonoBehaviour
{
    public Rigidbody2D buttonRB;
    public GameObject button;
    public GameObject buttonTravel;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(button);
    }
}
