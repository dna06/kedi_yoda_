using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleSlider : MonoBehaviour
{
    [SerializeField] private GameObject m_robot = null; //a variable to store the robot object - this is referenced via the inspector
    
    public void SliderValueChanged(float sliderValue)//this method gets called when the slider changes - it's referenced via the inspector
    {
        m_robot.transform.localScale = new Vector3(sliderValue, sliderValue, sliderValue); //set the robot scale to the slider value / the slider value is clamped to a range of 0.25 - 3 via the inspector.
    }
}
