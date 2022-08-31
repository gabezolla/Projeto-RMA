using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiferentialBotControl : MonoBehaviour
{
    public float CarSpeed = 1;
    public float RotateSpeed = 1;
    public float deltaT = 1f;

    void Start()
    {
        InvokeRepeating("Main", 0.1f, deltaT);
    }

    public Camera Cam1;
    public Camera Cam2;
    public Camera Cam3;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Cam1.gameObject.SetActive(true);
            Cam2.gameObject.SetActive(false);
            Cam3.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Cam1.gameObject.SetActive(false);
            Cam2.gameObject.SetActive(true);
            Cam3.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            Cam1.gameObject.SetActive(false);
            Cam2.gameObject.SetActive(false);
            Cam3.gameObject.SetActive(true);
        }
    }

    void Main()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-CarSpeed, 0, 0);            
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(CarSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -RotateSpeed, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, RotateSpeed, 0);
        }
    }
}