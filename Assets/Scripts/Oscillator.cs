using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [Header("OBJ")]
    public Transform PendulamTrans;

    [Header("SETTINGS")]
    public float RotTime = 0;
    public float RotAngle = 40;
    public float RotSpeed = 2;
    public float SlowFactor = 0.9999f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PendulamTrans)
        {
            RotTime += Time.deltaTime * RotSpeed;
            PendulamTrans.rotation = Quaternion.Euler(0, 0, RotAngle * Mathf.Sin(RotTime));

            RotSpeed *= SlowFactor;
        }


    }
}
