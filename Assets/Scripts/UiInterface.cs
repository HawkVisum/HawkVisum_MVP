using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
public class UiInterface : MonoBehaviour
{
    public Button[] buttons;
    public bool anyButtonHover;
    private void Update()
    {
        
      for(int i=0; i<buttons.Length; i++)
        {
            if (buttons[i].GetComponent<SlideButton>().onHover == true && anyButtonHover)
            {
                buttons[i].GetComponent<SlideButton>().FullOpacity();
            }
            else if(anyButtonHover && buttons[i].GetComponent<SlideButton>().onHover == false)
            {
                buttons[i].GetComponent<SlideButton>().HalfOpacity();
            }
            else if(!anyButtonHover && buttons[i].GetComponent<SlideButton>().onHover == false)
            {
                buttons[i].GetComponent<SlideButton>().FullOpacity();
            }
           
        }
     
    }

}
