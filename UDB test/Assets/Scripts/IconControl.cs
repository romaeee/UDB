using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconControl : MonoBehaviour
{
    public static List<string> typeList = new List<string>();

    public Sprite carImage;
    public Sprite bikeImage;
    public Sprite planeImage;

    private Image myIMGcomponent;

    void Start()
    {
        for (int i = 0; i < typeList.Count; i++)
        {
            if (typeList[i].ToString() == "Car")
            {
                myIMGcomponent = this.GetComponent<Image>();
                myIMGcomponent.sprite = carImage;
                typeList.Remove(typeList[i]);
                break;
            }
            else if (typeList[i].ToString() == "Bike")
            {
                myIMGcomponent = this.GetComponent<Image>();
                myIMGcomponent.sprite = bikeImage;
                typeList.Remove(typeList[i]);
                break;
            }
            else if (typeList[i].ToString() == "Plane")
            {
                myIMGcomponent = this.GetComponent<Image>();
                myIMGcomponent.sprite = planeImage;
                typeList.Remove(typeList[i]);
                break;
            }
        }
    }
}
