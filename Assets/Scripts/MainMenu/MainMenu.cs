using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class MainMenu : MonoBehaviour
{
    public enum MySampleEnum { a,b,c,d,e,f,g,h,j,i}
    public Dropdown exampleDropdown;
    // Start is called before the first frame update
    void Start()
    {
        exampleDropdown.options.Clear();
        exampleDropdown.AddOptions(Enum.GetNames(typeof(MySampleEnum)).ToList());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DropdownChanged(int optSelected)
    {
        MySampleEnum myValue = (MySampleEnum)optSelected;
        //string selectedOption = exampleDropdown.options[optSelected].text;
        //Debug.Log("selected dropdown:" + selectedOption);
        Debug.Log("selected dropdown:" + myValue);
    }

    public void ToggleButton(bool b)
    {
        Debug.Log("bool: " + b);
    }

    public void StartButtonPressed()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

    public void ButtonWasPressed(Transform t)
    {
        Debug.Log("button pressed: " + t.name);
        //if(t.name == "StartButton")


    }

}
