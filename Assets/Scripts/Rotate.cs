using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
    

{
    public GameObject Rotate1;
    public void RotateObject()
    {
        Rotate1.transform.Rotate(new Vector3(0f, 15f, 0f));
    }
}
