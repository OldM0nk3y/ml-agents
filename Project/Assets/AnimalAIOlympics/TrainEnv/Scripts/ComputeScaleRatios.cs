// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngineExtensions;


public class ComputeScaleRatios : MonoBehaviour
{


    void Start()
    {

        Vector3 sizeReal = gameObject.GetBoundsWithChildren().extents * 2;
        Vector3 scaleReal = transform.localScale;
        Vector3 ratioSize = new Vector3(scaleReal.x / sizeReal.x,
                                        scaleReal.y / sizeReal.y,
                                        scaleReal.z / sizeReal.z);

        Debug.Log("===== Object " + gameObject.name + " ======");
        Debug.Log(ratioSize.ToString("F8"));
        Debug.Log("=====================");



        // Debug.Log("===== Object " + gameObject.name + " ======");
        // // Debug.Log(sizeReal.ToString("F8"));
        // Debug.Log(transform.localPosition.ToString("F8"));
        // Debug.Log("=====================");

    }


}

