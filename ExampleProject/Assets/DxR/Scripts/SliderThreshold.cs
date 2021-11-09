using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

namespace DxR
{
    public class SliderThreshold : MonoBehaviour
    {
        public float MIN_VALUE;
        public float MAX_VALUE;
        public Microsoft.MixedReality.Toolkit.UI.PinchSlider sliderControl;
        TextMesh valueLabel;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Init(float min, float max)
        {
            MIN_VALUE = min;
            MAX_VALUE = max;

            this.transform.parent.Find("ThresholdFilterMinLabel").GetComponent<TextMesh>().text = min.ToString();
            this.transform.parent.Find("ThresholdFilterMaxLabel").GetComponent<TextMesh>().text = max.ToString();

            sliderControl = this.GetComponent<Microsoft.MixedReality.Toolkit.UI.PinchSlider>();

            sliderControl.SliderValue = 1;

            sliderControl.OnValueUpdated.AddListener(UpdateValueLabel);
        }

        private void UpdateValueLabel(SliderEventData sliderData)
        {
            if (valueLabel == null)
            {
                valueLabel = transform.parent.Find("SliderValue").GetComponent<TextMesh>();
            }
            valueLabel.text = ((int)(sliderData.NewValue * (MAX_VALUE - MIN_VALUE) + MIN_VALUE)).ToString();
        }

        public float GetThresholdValue()
        {
            return sliderControl.SliderValue * (MAX_VALUE - MIN_VALUE) + MIN_VALUE;
        }

        public void UpdatePosition()
        {
            // aggiorno la posizione in modo che stia su tutta l'axis
            // this.transform.parent
        }


    }
}