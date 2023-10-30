using System;
using UnityEngine;

namespace Code.Services.InputSystem
{
    public interface IInputService
    {
        event Action Clicked;

        float GetRotationAngle();
    }

    public class MouseInputService : IInputService
    {
        private const string AxisName = "Mouse X";
        
        public event Action Clicked;

        public float GetRotationAngle()
        {
            if (Input.GetMouseButton(0))
                return Input.GetAxis(AxisName);

            return 0;
        }
    }
}