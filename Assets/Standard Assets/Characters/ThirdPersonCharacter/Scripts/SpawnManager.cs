using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Vector3[] boxSpawnLocations;
    public Vector3[] boxSpawnRotations;
    public GameObject boxPrefab;
    private PlayerController playerCtrl; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSmallBox", 3.0f, 1.5f);
        playerCtrl = GameObject.Find("ThirdPersonController").GetComponent<PlayerController>(); 
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnSmallBox()
    
    {
        if (playerCtrl.gameOver == false)
        {
            int boxRandomNumber = Random.Range(1, 600);
            if(boxRandomNumber < 300)
            {
                Instantiate(boxPrefab, boxSpawnLocations[0],
                 Quaternion.Euler(boxSpawnRotations[0]));
            }
            else if (boxRandomNumber < 500)
            {
                Instantiate(boxPrefab, boxSpawnLocations[2],
                 Quaternion.Euler(boxSpawnRotations[2]));
            }
            else
            {
                Instantiate(boxPrefab, boxSpawnLocations[1],
                Quaternion.Euler(boxSpawnRotations[1]));
            }
        }
    }   

}
