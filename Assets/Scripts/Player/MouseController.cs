using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Undercooked
{
    public class MouseController : MonoBehaviour
    {
        public float mouseSpeed = 100f;
        public Transform cam;

        float mouseX;
        float mouseY;
        float yreal = 0.0f;
        // Update is called once per frame
        private void Start() {
            Cursor.lockState = CursorLockMode.Locked;
        }
        void Update()
        {
            mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
            mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;
            yreal -= mouseY;

            yreal = Mathf.Clamp(yreal, -90f, 90f);
            cam.localRotation = Quaternion.Euler(yreal, 0f, 0f);
            transform.Rotate(Vector3.up * mouseX);
        }
    }
}
