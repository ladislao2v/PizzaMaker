using Code.Services.InputSystem;
using UnityEngine;
using Zenject;

namespace Code.Views.Camera
{
    public class CameraView : MonoBehaviour
    {
        [SerializeField] private float _rotationSpeed;
        
        private IInputService _inputService;

        [Inject]
        private void Construct(IInputService inputService)
        {
            _inputService = inputService;
        }

        private void Update()
        {
            Rotate(_inputService.GetRotationAngle() * _rotationSpeed);
        }

        private void Rotate(float angle)
        {
            transform.Rotate(0, angle, 0);
        }
    }
}