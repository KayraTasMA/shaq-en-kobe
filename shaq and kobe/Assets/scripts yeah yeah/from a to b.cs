using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fromatob : MonoBehaviour
{
    [SerializeField] GameObject  A;
    [SerializeField] GameObject B;
     [SerializeField] GameObject C;
     [SerializeField] GameObject D;
    [SerializeField] Vector3 differenceVector;
    [SerializeField] float distance;
    Vector3 direction;
    float speed = 11;
    bool gotoB =        true;
    void Start()
    {
        transform.position = A.transform.position;
    }

    
    void Update()
    {
        if (gotoB)
        {
            differenceVector = B.transform.position - transform.position;
        }
        else
        {
            differenceVector = A.transform.position - transform.position;
        }
        
        distance = differenceVector.magnitude;
        direction = differenceVector.normalized;

        transform.position += direction * speed * Time.deltaTime;

    if(distance < speed*Time.deltaTime)
    {
        gotoB = !gotoB; 
     }
    }
}
