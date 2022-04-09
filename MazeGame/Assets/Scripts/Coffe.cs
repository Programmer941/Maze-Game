using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffe : MonoBehaviour
{
    // Start is called before the first frame update
    bool won = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (won)
        {
                        GetComponent<Renderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coffe"))
        {
            Debug.Log("won");
            won = true;
        }
    }


}
