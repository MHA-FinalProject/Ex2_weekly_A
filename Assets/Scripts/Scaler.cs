using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    Vector3 temp;
    public float speed = 7.0f;
    public float MinScale = 10f;
    public float MaxScale = 12f;
    public bool state = true;

    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (state) {
            if (transform.localScale.x >= MaxScale)
            {
                state = false;
            }
            else { 
                temp = transform.localScale;

                temp.x += Time.deltaTime * speed;
                temp.y += Time.deltaTime * speed;

                transform.localScale = temp;

            }
        }

        else
        {
            if (transform.localScale.x <= MinScale)
            {
                state = true;
            }
            else {
                temp = transform.localScale;

                temp.x -= Time.deltaTime * speed;
                temp.y -= Time.deltaTime * speed;

                transform.localScale = temp;
            }

        }


    }
}
