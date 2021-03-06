using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topOfScene = 200.0f;
    private float bottomOfScene = -200.0f;
    private float leftOfScene = 200.0f;
    private float rightOfScene = -200.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topOfScene)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomOfScene)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > leftOfScene)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < rightOfScene)
        {
            Destroy(gameObject);
        }
    }
}
