using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Characters.PlayerMovement
{
    [CreateAssetMenu(menuName = "Characters/Player/Movement Settings")]

    public class PlayerMovementSettings : ScriptableObject
    {
        

        public float HorizontalSpeed = 5;
        public float VerticalSpeed = 5;

    }
}