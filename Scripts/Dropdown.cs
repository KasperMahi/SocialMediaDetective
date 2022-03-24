using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dropdown : MonoBehaviour
{
    public TextMeshProUGUI output;
    public int CorrectOptionIndex1;
    public int CorrectOptionIndex2;
    public int CorrectOptionIndex3;

    [HideInInspector] // Hides var below
    public bool Dropdown1Answer;
    [HideInInspector] // Hides var below
    public bool Dropdown2Answer;
    [HideInInspector] // Hides var below
    public bool Dropdown3Answer;



    public void HandleInput1(int val)
    {
        if (val == CorrectOptionIndex1)
        {
            Dropdown1Answer = true;
        }
        else
        {
            Dropdown1Answer = false;
        }
        HandleOutput();

    }

    public void HandleInput2(int val)
    {
        if (val == CorrectOptionIndex2)
        {
            Dropdown2Answer = true;
        }
        else
        {
            Dropdown2Answer = false;
        }
        HandleOutput();

    }

    public void HandleInput3(int val)
    {
        if (val == CorrectOptionIndex3)
        {
            Dropdown3Answer = true;
        }
        else
        {
            Dropdown3Answer = false;
        }
        HandleOutput();

    }

    public void HandleOutput()
    {
        if (Dropdown1Answer == true && Dropdown2Answer == true && Dropdown3Answer == true)
        {
            output.text = "Your followers are sure to love it! You win!";
        }
        else
        {
            output.text = "Your post will be mocked forever, try again.";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
