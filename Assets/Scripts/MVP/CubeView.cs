
using System;
using UnityEngine;

namespace MVP
{
    public class CubeView:MonoBehaviour
    {
        [SerializeField] private Transform _transform;
        
        public void OnAngleChanged(float angle)
        {
            _transform.rotation = Quaternion.Euler(new Vector3(0,angle,0));
        }
    }
}