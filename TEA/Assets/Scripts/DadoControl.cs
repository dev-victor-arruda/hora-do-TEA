using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DadoControl : MonoBehaviour
{
    private bool isRolling = false;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Verifique se a tecla "R" foi pressionada.
        if (Input.GetKeyDown(KeyCode.R) && !isRolling)
        {
            // Gire o dado aleatoriamente.
            Vector3 torque = Random.insideUnitSphere * 500;
            rb.AddTorque(torque);
            isRolling = true;
        }
    }
}

