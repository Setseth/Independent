using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI status;
    private int orb = 0; 

    // Start is called before the first frame update
    void Start()
    {
        UpdateStatus(0);
    }

    private void UpdateStatus(int statusDelta)
    {
        status += statusDelta;
        status.text = "Orb: " + orb;
    }
}
