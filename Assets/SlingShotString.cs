using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SlingShotString : MonoBehaviour
{
    public Transform Leftpoint;
    public Transform RightPoint;
    public Transform CenterPoint;

    public LineRenderer slingshotString;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slingshotString = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        slingshotString.SetPositions(new Vector3[3] { Leftpoint.position, CenterPoint.position, RightPoint.position });
    }
}
