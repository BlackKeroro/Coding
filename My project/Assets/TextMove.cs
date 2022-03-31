using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMove : MonoBehaviour
{

    int Speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, Speed * Time.deltaTime, 0));

    }
}
