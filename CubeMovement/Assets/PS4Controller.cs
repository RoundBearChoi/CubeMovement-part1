using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace RB
{
    public class PS4Controller : MonoBehaviour
    {
        GameObject cube = null;

        private void Start()
        {
            for (int i = 0; i < Gamepad.all.Count; i++)
            {
                Debug.Log(Gamepad.all[i].name);
            }

            cube = GameObject.Find("Cube");
        }

        private void Update()
        {
            if (Gamepad.all.Count > 0)
            {
                if (Gamepad.all[0].leftStick.left.isPressed)
                {
                    cube.transform.position += Vector3.left * Time.deltaTime * 5f;
                }

                if (Gamepad.all[0].leftStick.right.isPressed)
                {
                    cube.transform.position += Vector3.right * Time.deltaTime * 5f;
                }

                if (Gamepad.all[0].leftStick.up.isPressed)
                {
                    cube.transform.position += Vector3.up * Time.deltaTime * 5f;
                }

                if (Gamepad.all[0].leftStick.down.isPressed)
                {
                    cube.transform.position += Vector3.down * Time.deltaTime * 5f;
                }

                if (Gamepad.all[0].buttonSouth.wasPressedThisFrame)
                {
                    Debug.Log("X pressed!");
                }
            }
        }
    }
}