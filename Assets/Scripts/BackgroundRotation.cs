using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRotation : MonoBehaviour
{
    public float _backgroundRotation;
    private void Update()
    {
        transform.Rotate(Vector3.down * _backgroundRotation * Time.deltaTime);
    }
}
