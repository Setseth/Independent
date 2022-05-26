using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI status;
    public TextMeshProUGUI failure; 
    private bool orb = false; 

    // Start is called before the first frame update
    void Start()
    {
        UpdateStatus(false);
    }

    public void GameOver()
    {
        failure.gameObject.SetActive(true);
    }

    public void UpdateStatus(bool state)
    {
        orb = state;
        status.text = "Orb: " + orb.ToString();
    }
}
