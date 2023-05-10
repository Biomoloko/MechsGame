using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float rotSpeed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 point = ray.GetPoint(30);

        Vector3 distance = point - transform.position;
        Quaternion quaternion = Quaternion.LookRotation(distance);

        Quaternion local = transform.localRotation;

        Vector3 vector = Quaternion.Lerp(local, quaternion, rotSpeed * Time.deltaTime).eulerAngles;
        Debug.Log(transform.parent.rotation.y);
        if(vector.y < 60 || vector.y > 300)
            transform.localRotation = Quaternion.Euler(local.eulerAngles.x, vector.y, local.eulerAngles.z);
    }
}
