using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -45f)
        {
            transform.position = new Vector3(Random.Range(-60f, 60f), 45f, 0); 
        }
        transform.Translate(new Vector3(-1,-1,0));
    }
}
