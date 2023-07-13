using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float impulso = 1.5f;
    public float velocidadDeRotacion = 10f;
    private Rigidbody2D rb;

    private AudioSource audioSource;
    public AudioClip jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame || Keyboard.current.spaceKey.wasPressedThisFrame)
        {

            Jump();
        }
    }

    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * velocidadDeRotacion);
    }

    void OnCollisionEnter2D(Collision2D collission)
    {
        GameManager.instance.GameOver();
    }

    private void Jump()
    {
        rb.velocity = Vector2.up * impulso;
        if(!audioSource.isPlaying )
        {
            audioSource.PlayOneShot(jumpSound);
        }
    }
}
