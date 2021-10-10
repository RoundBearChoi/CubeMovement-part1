using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace RB
{
    public class MoveCube : MonoBehaviour
    {
        Gamepad _gamepad = null;
        float _speed = 5f;

        private void Start()
        {
            if (Gamepad.all.Count > 0)
            {
                _gamepad = Gamepad.all[0];
            }
        }

        private void Update()
        {
            if (_gamepad.leftStick.left.isPressed)
            {
                this.gameObject.transform.position += Vector3.left * Time.deltaTime * _speed;
            }

            if (_gamepad.leftStick.right.isPressed)
            {
                this.gameObject.transform.position += Vector3.right * Time.deltaTime * _speed;
            }

            if (_gamepad.leftStick.up.isPressed)
            {
                this.gameObject.transform.position += Vector3.up * Time.deltaTime * _speed;
            }

            if (_gamepad.leftStick.down.isPressed)
            {
                this.gameObject.transform.position += Vector3.down * Time.deltaTime * _speed;
            }
        }
    }
}