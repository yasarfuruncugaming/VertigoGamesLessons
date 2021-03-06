﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Characters.PlayerInput

{

    public class InputManager : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;

        
        private void Update()
        {

            _inputData.Horizontal = Input.GetAxis("Horizontal");
            _inputData.Vertical = Input .GetAxis("Vertical");


        }
    }
}
