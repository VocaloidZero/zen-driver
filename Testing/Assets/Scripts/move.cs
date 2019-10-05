using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField, Tooltip("This controls the players speed")]
    private float speed = 5.0f;
    public float turnSpeed = 25.0f;
    private float horiInput;
    private float forwardInput;
    //AudioSource bubbleEngine;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horiInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horiInput);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //bubbleEngine = GetComponent<>();
            //bubbleEngine.Play(0);
            Debug.Log("started");
        }
    }
}
