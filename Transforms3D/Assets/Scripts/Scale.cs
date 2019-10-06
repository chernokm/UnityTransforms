using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public float speed = 5f;
    Vector3 temp;
    Vector3 temp2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        temp = transform.localScale;
        temp.x += Time.deltaTime;
        transform.localScale = temp;

        temp2 = transform.localScale;
        temp2.z += Time.deltaTime;
        transform.localScale = temp2;
    }
}
