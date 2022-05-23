using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPlatform : MonoBehaviour
{
    public GameObject orb;
    private Renderer orbRenderer;

    // Start is called before the first frame update
    void Start()
    {
        orbRenderer = orb.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("PlatformOnCollisionEnter");
            StartCoroutine(Fade());
        }
    }
    IEnumerator Fade()
    {
        orbRenderer.material.color = new Color(1, 0, 1, 1);
        Color c = orbRenderer.material.color;
        Debug.Log("SettingAlpha" + c.a); 
        for (float alpha = 0f; alpha >= 1; alpha -= 1.0f)
        {
            c.a = alpha;
           orbRenderer.material.color = c;
            yield return new WaitForSeconds(.1f);
        }
    }
}
