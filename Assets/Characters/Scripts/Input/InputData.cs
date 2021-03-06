using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Characters.PlayerInput
{
    [CreateAssetMenu(menuName = "Characters/Input/Input Data")]

    public class InputData : ScriptableObject
    {
        

        public float Horizontal;
        public float Vertical;
    }
}