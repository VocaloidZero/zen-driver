using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPaint : MonoBehaviour
{
    Color paintColor;
    float paintRemaining;
    bool canPaint = false;

    [SerializeField]
    private Material carMaterial;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        Paint();
        //OnCollisionEnter(this.GetComponent<Collider>()); //the car's collider
    }

    public void Paint()
    {
        if (canPaint)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                paintRemaining -= Time.deltaTime;
                Debug.Log(paintRemaining);
            }
        }
    }


    //while space
    //set can paint true
    //start running out of paint

     void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "PaintCan")
        {
            //set car's material color to paint can's color

            Material paintCanMaterial = collider.gameObject.GetComponent<Renderer>().material;
            carMaterial.color = paintCanMaterial.color;
           
            Debug.Log("collides w paintcan");
        }
    }


    public void SetPaintColor(Color paintColor)
    {
        this.paintColor = paintColor;
        canPaint = true;

    }

    public void SetPaintRemaining(float paintRemaining)
    {
        this.paintRemaining = paintRemaining;
    }
}
