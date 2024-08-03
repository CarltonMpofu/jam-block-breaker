using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // reference to paddle
    [SerializeField] Player paddle;

    [SerializeField] float xSpeed, ySpeed = 0;

    [SerializeField] AudioClip[] audioClips;

    Vector2 difference;

    Rigidbody2D rb;

    bool hasStarted;


    // Start is called before the first frame update
    void Start()
    {
        hasStarted = false;
        difference = transform.position - paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(hasStarted == false)
        {
            AttachBallToPaddle();
            LaunchBall();
        }
        
    }

    void AttachBallToPaddle()
    {
        Vector2 paddlePosition = new Vector2(paddle.transform.position.x, paddle.transform.position.y);

        transform.position = paddlePosition + difference;  
    }

    void LaunchBall()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            hasStarted = true;

            rb = GetComponent<Rigidbody2D>();

            rb.velocity = new Vector2(xSpeed, ySpeed);
        }
        
    }
    
    private void OnCollisionEnter2D(Collision2D other) 
    {
        int idx = Random.Range(0, audioClips.Length);

        AudioClip audioClip = audioClips[idx];

        GetComponent<AudioSource>().PlayOneShot(audioClip);
    }


}
