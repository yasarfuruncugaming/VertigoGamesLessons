 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{

    public class ControlRigidbody : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private Vector3 _jumpForce;

         
        private void Update()
        {
            bool spaceKeyDown = Input.GetKeyDown(KeyCode.Space);
            if (spaceKeyDown)
            {
                Debug.Log("space down");

                _rigidbody.AddForce(_jumpForce, ForceMode.Impulse);
 

               
            }


        }


    }
}
