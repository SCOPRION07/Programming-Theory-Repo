using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    // Start is called before the first frame update
    void Start()
    {
        if (MainManager.Instance.NameInput.text != null)
            nameText.text = MainManager.Instance.NameInput.text;
        else
        {
            nameText.text = " heyy !! ";
        }
    }


}
