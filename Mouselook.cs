using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player

{

    [AddComponentMenu("Game Systems/RPG/PLayer/Movement,look")]
    public class Mouselook : MonoBehaviour
    {
        public enum RotationalAxis
        {
            MouseX,
            MouseY
        }
        [Header("Rotational Variables")]
        public RotationalAxis axis = RotationalAxis.MouseX;
        [Range(0, 200)]
        public float sensitivity = 100;
        public float minY = -60, maxY = 60;
        private float _rotY;


        // Start is called before the first frame update
        void Start()
        {
            if (GetComponent<Rigidbody>())
            {
                GetComponent<Rigidbody>().freezeRotation = false;
            }
            if (GetComponent<Camera>())
            {
                axis = RotationalAxis.MouseY;
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (axis == RotationalAxis.MouseX)
            {
                transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime, 0);
            }
            else
            {
                _rotY += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
                _rotY = Mathf.Clamp(_rotY, minY, maxY);
                transform.localEulerAngles = new Vector3(-_rotY, 0, 0);
            }
        }
    }
}

