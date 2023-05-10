using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speedMovementCof;
    public float speedRotationCof;

    //public GameObject leftBorderNear;
    //public GameObject rightBorderNear;

    //public GameObject leftBorderFar;
    //public GameObject rightBorderFar;

    //public float bordersXDistanceNear;
    //public float bordersXDistanceFar;
    //public float nearBordersZDistance;
    //public float farBordersZDistance;

    //public GameObject head;
    //public GameObject pointer;
    //public GameObject headTargetNear;
    //public GameObject headTargetFar;

    private Camera cam;

    //public float headSpeed;

    public Animations animations;

    //private float pointerPosZ;

    private Transform Legs;
    private Transform Head;


    void Start()
    {
        cam = Camera.main;
        Legs = transform.GetChild(0);
        Head = transform.GetChild(2);

    }

    void Update()
    {
        //Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        //Debug.DrawRay(ray.origin, ray.direction * 20);
        //RaycastHit hit;
        //if (Physics.Raycast(ray, out hit))
        //{
        //    pointer.transform.position = hit.point;
        //}

        //pointerPosZ = pointer.transform.localPosition.z;
        PlayerMovement();
        //HeadRotation();
    }

    public void PlayerMovement()
    {
        float horRotate = Input.GetAxis("Horizontal") * Time.deltaTime * speedRotationCof;
        float vertMove = Input.GetAxis("Vertical") * Time.deltaTime * speedMovementCof;
        transform.position += -Legs.up * vertMove;
        Legs.Rotate(0, 0, horRotate);
        Head.Rotate(0, horRotate, 0);

        //animations.AnimLogic(horRotate, vertMove);
    }
    //public void HeadRotation()
    //{
        
    //    #region my own code


    //    // distance of near and far borders from mech on Z axis
    //    leftBorderNear.transform.localPosition = new Vector3(-bordersXDistanceNear, leftBorderNear.transform.localPosition.y, nearBordersZDistance);
    //    rightBorderNear.transform.localPosition = new Vector3(bordersXDistanceNear, leftBorderNear.transform.localPosition.y, nearBordersZDistance);

    //    leftBorderFar.transform.localPosition = new Vector3(-bordersXDistanceFar, leftBorderNear.transform.localPosition.y, nearBordersZDistance * 4);
    //    rightBorderFar.transform.localPosition = new Vector3(bordersXDistanceFar, leftBorderNear.transform.localPosition.y, nearBordersZDistance * 4);
        

    //    // position of targets for LookAt
    //    headTargetNear.transform.localPosition = new Vector3(Mathf.Clamp(pointer.transform.localPosition.x, leftBorderNear.transform.localPosition.x, rightBorderNear.transform.localPosition.x),
    //                                                    head.transform.localPosition.y,
    //                                                    leftBorderNear.transform.localPosition.z);

    //    headTargetFar.transform.localPosition = new Vector3(Mathf.Clamp(pointer.transform.localPosition.x*1.5f, leftBorderFar.transform.localPosition.x, rightBorderFar.transform.localPosition.x),
    //                                                    head.transform.localPosition.y,
    //                                                    leftBorderFar.transform.localPosition.z);


    //    var targetRotation = Quaternion.LookRotation(TargetForLookAt().localPosition - head.transform.localPosition);
    //    head.transform.localRotation = Quaternion.RotateTowards(head.transform.localRotation, targetRotation, headSpeed * Time.deltaTime);
        


    //    #endregion

    //}

    //public Transform TargetForLookAt()
    //{
    //    if (Mathf.Abs(headTargetFar.transform.localPosition.z - pointerPosZ) < Mathf.Abs(headTargetNear.transform.localPosition.z - pointerPosZ))
    //        return headTargetFar.transform;
    //    else
    //        return headTargetNear.transform;
    //}
}
