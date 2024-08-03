using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float paddleSpeed = 10f;

    [SerializeField] float minValue = -3f;

    [SerializeField] float maxValue = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float axisValue = Input.GetAxis("Horizontal");

        //Debug.Log(axisValue);

        float playerSpeed = axisValue * paddleSpeed * Time.deltaTime; 

        Vector3 playerPosition = transform.position + new Vector3(playerSpeed, 0 , 0);
        
        float xPosition = Mathf.Clamp(playerPosition.x, minValue, maxValue);

        transform.position = new Vector3(xPosition, playerPosition.y, 0);
    }
}
