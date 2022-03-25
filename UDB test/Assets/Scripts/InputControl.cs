using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputControl : MonoBehaviour
{
    public GameObject testObject;
    public CardManager[] Types;

    private bool isCreate = false;

    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("InputManager");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

        
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "DataBase" && !isCreate)
        {
            Create();
        }
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            isCreate = false;
        }
    }

    private void Create()
    {
        isCreate = true;
        if(SceneManager.GetActiveScene().name == "DataBase")
        {
            for (int i = 0; i < Types.Length; i++)
            {
                testObject.transform.Find("Name").GetComponent<Text>().text = Types[i].Name;
                testObject.transform.Find("Mass").GetComponent<Text>().text = "Масса - " + Types[i].Mass;
                testObject.transform.Find("Capacities").GetComponent<Text>().text = "Вместимость - " + Types[i].Capacities;
                testObject.transform.Find("Speed").GetComponent<Text>().text = "Макс. Скорость - " + Types[i].Speed;
                if (Types[i].ItemType.ToString() == "Car")
                {
                    testObject.transform.Find("Additionally").GetComponent<Text>().text = "Цвет - " + Types[i].Other;
                }
                else if (Types[i].ItemType.ToString() == "Bike")
                {
                    testObject.transform.Find("Additionally").GetComponent<Text>().text = "Габариты - " + Types[i].Other;
                }
                else if (Types[i].ItemType.ToString() == "Plane")
                {
                    testObject.transform.Find("Additionally").GetComponent<Text>().text = "Дальность - " + Types[i].Other;
                }
                GameObject go = Instantiate(testObject, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
                go.transform.parent = GameObject.Find("Content").transform;

                IconControl.typeList.Add(Types[i].ItemType.ToString());
            }
        }
        
    }
}