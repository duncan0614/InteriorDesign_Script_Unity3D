﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textpercentage : MonoBehaviour {

    Text percentageText;

    void Start()
    {
        percentageText = GetComponent<Text>();

    }
    public void textUpdate(float value)
    {
        percentageText.text = Mathf.RoundToInt(value) + "%";
    }
}
