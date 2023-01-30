using System;
using UniRx;
using UnityEngine;

namespace MVP
{
    public class CubeRotatePresenter:MonoBehaviour
    {
        [SerializeField] private RotationModel rotationModel;
        [SerializeField] private ButtonView buttonView;
        [SerializeField] private CubeView cubeView;

        public void Start()
        {
            Initialize();
        }
        
        public void Initialize()
        {
            rotationModel.Initialize();
            Bind();
            SetEvents();
        }

        private void Bind()
        {
            rotationModel.RotateAngle.Subscribe(cubeView.OnAngleChanged).AddTo(gameObject);
        }

        private void SetEvents()
        {
            buttonView.OnButtonClickedListener = OnButtonClicked;
        }

        private void OnButtonClicked()
        {
            rotationModel.SetOnOFF();
        }
    }
}