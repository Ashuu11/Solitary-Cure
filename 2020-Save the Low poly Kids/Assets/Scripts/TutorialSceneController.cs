using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialSceneController : MonoBehaviour
{
    public Sprite[] gallery; //store all your images in here at design time
    public Image displayImage; //The current image thats visible
    public Button nextbtn; //Button to view next image
    public Button prevbtn; //Button to view previous image
    public int i = 0; //Will control where in the array you are

    public void BtnNext()
    {
        if (i + 1 < gallery.Length)
        {
            i++;
        }
    }

    public void BtnPrev()
    {
        if (i - 1 > 0)
        {
            i--;
        }
    }

    void Update()
    {
        displayImage.sprite = gallery[i];
    }
}
