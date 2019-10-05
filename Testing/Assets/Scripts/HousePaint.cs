using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HousePaint : MonoBehaviour
{
    Color paintColor;
    float paintRemaining;
    bool canPaint = false;

    [SerializeField]
    private Material houseMaterial;

    [SerializeField]
    private Material carMaterial;

    // Start is called before the first frame update
    void Start()
    {
        //this.gameObject.GetComponent<Renderer>().material = new Renderer().material;
        //houseMaterial = new Renderer().material;   //this.gameObject.GetComponent<Renderer>().material;
        houseMaterial.color = new Color(255,255,255,0);
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
        if (collider.gameObject.tag == "CarBody")
        {
            //set car's material color to paint can's color

            //Material carMaterial = collider.gameObject.GetComponent<Renderer>().material;
            houseMaterial.color = carMaterial.color;

            Debug.Log("collides w house");
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
