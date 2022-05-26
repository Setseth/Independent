using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rbPlayer;
    public float jumpforce;
    public bool onGround = true;
    public bool gameOver = false;
    private Animator animPlayer;
    public ParticleSystem expSystem;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource asPlayer;

    bool hasPowerUp = false; 


    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();

        animPlayer = GetComponent<Animator>();

        asPlayer = GetComponent<AudioSource>();
    }

    void Update()
    {
        bool spaceDown = Input.GetKeyDown(KeyCode.Space);
        // Conditions met to jump!
        if (spaceDown && onGround && !gameOver)
        {
            // jump code
            rbPlayer.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            asPlayer.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DeathZone"))
        {
            expSystem.Play();
            Debug.Log("Game Over!");
            gameOver = true;
        }
        if (other.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            Destroy(other.gameObject); 
            jumpforce = 12;
            StartCoroutine(PowerUpCountdown());
        }
    }
    IEnumerator PowerUpCountdown()
    {
        yield return new WaitForSeconds(15);
        jumpforce = 3;
        hasPowerUp = false;
    }
}

