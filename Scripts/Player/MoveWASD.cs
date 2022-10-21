using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWASD : MonoBehaviour
{
    public float hizCarpani;

    private float MovementSpeed;

    private float DashSpeed;

    private float StaminaMax;
    private float Stamina;

    public void setMovementSpeed(float a)
    {
        MovementSpeed = a;
    }
    public float getMovementSpeed()
    {
        return MovementSpeed;
    }
    public void setDashSpeed(float a)
    {
        DashSpeed = a;
    }
    public float getDashSpeed()
    {
        return DashSpeed;
    }
    public void setStaminaMax(float a)
    {
        StaminaMax = a;
    }
    public float getStaminaMax()
    {
        return StaminaMax;
    }


    void Start()
    {
        setMovementSpeed(4);
        setDashSpeed(10);
        setStaminaMax(10);
        Stamina = StaminaMax;
    }

    public void MoveMe()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, MovementSpeed * hizCarpani * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -MovementSpeed * hizCarpani * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-MovementSpeed * hizCarpani * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(MovementSpeed * hizCarpani * Time.deltaTime, 0, 0);
        }
    }
    public void DashMe()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, DashSpeed * hizCarpani * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -DashSpeed * hizCarpani * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-DashSpeed * hizCarpani * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(DashSpeed * hizCarpani * Time.deltaTime, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            hizCarpani = 0.7071f;
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            hizCarpani = 0.7071f;
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            hizCarpani = 0.7071f;
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            hizCarpani = 0.7071f;
        }
        if (Input.GetKey(KeyCode.LeftShift) && Stamina>0)
        {
            DashMe();
        }
        else
        {
            MoveMe();
        }
        hizCarpani = 1;


        if (Input.GetKey(KeyCode.L))
        {
            Time.timeScale = 1f;
        }
        if (Input.GetKey(KeyCode.K))
        {
            Time.timeScale = 0.1f;
        }
        if (Input.GetKey(KeyCode.J))
        {
            Time.timeScale = 0f;
        }


    }
}
