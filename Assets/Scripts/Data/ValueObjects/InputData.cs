using System;
using UnityEngine;

namespace Data.ValueObjects
{
    [Serializable]
    public struct InputData
    {
        public float HorizontalIUnputSpeed;
        public Vector2 ClampValues;
        public float ClampSpeed;
    }
}