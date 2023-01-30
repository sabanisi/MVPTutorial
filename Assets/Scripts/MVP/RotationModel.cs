using UniRx;
using UnityEngine;

namespace MVP
{
    public class RotationModel:MonoBehaviour
    {
        [SerializeField] private float rotateSpeed;
        private ReactiveProperty<float> _rotateAngle;

        public IReadOnlyReactiveProperty<float> RotateAngle
        {
            get { return _rotateAngle; }
        }

        private bool isOn;

        public void Initialize()
        {
            _rotateAngle = new ReactiveProperty<float>(0);
            isOn = false;
        }
        
        //スタート/ストップを切り替える
        public void SetOnOFF()
        {
            isOn = !isOn;
        }

        public void Update()
        {
            if (isOn)
            {
                _rotateAngle.Value += rotateSpeed * Time.deltaTime;
                if (_rotateAngle.Value > 360)
                {
                    _rotateAngle.Value -= 360;
                }
            }
        }
    }
}