using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePowerUp : MonoBehaviour
{
    // Start is called before the first frame update

    public float rotationSpeed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0, rotationSpeed, 0));
        
    }
}
