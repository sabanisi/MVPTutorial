using System;
using UnityEngine;
using UnityEngine.UI;
using MySystem;

namespace MVP
{
    public class ButtonView:MonoBehaviour
    {
        public Action OnButtonClickedListener;

        public void OnButtonClicked()
        {
            SystemUtility.SafeCall(OnButtonClickedListener);
            
        }
    }
}