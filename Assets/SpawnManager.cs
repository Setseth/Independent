using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Vector3[] boxSpawnLocations;
    public Vector3[] boxSpawnRotations;
    public GameObject boxPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSmallBox", 3.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnSmallBox()
    {
        int boxPrefabIndex = Random.Range(0, boxSpawnLocations.Length);
        Instantiate(boxPrefab, boxSpawnLocations[boxPrefabIndex],
          Quaternion.Euler(boxSpawnRotations[boxPrefabIndex]));
    }   

}
