using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Undercooked
{
    public class CanvasController : MonoBehaviour
    {
        // Start is called before the first frame update
        public Image imgSelector;
        public Slider sliderBar;

        public void ChangePickableBallColor(bool isSelect)
        {
            if(isSelect)
            {
                imgSelector.color = Color.yellow;
            }else{
                imgSelector.color = Color.white;
            }
        }

        public void OcultarCursor(bool ocultar)
        {
            imgSelector.enabled = !ocultar;
        }

        public void ActivarSlider(bool activar)
        {
            sliderBar.gameObject.SetActive(activar);
        }
        public void SetValueBar(float vld)
        {
            sliderBar.value = vld;
        }
    }
}
