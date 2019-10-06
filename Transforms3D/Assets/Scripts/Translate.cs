using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    float speedX = 1;
    float speedY = 0;
    float speedZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(speedX, speedY, speedZ) * Time.deltaTime);
    }
}
