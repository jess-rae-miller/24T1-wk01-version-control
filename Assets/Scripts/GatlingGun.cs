using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GatlingGun : MonoBehaviour
{
    [SerializeField] private bool isShooting = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //yadayada
            isShooting=true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            //yadayada
            isShooting = false;
        }
        if (!isShooting)
        {
            Debug.Log("yadayada");
        }
    }
}
