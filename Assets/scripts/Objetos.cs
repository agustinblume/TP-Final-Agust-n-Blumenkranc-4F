using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetos : MonoBehaviour
{
    public int currentIndex = -1;
    public GameObject[] objetos;
    // Start is called before the first frame update
    void Start()
    {
        Deactivateall();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex++;
            if (currentIndex >= objetos.Length)
            {
                currentIndex = 0;
            }
            Deactivateall();
            ActivateByIndex(currentIndex);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex--;
            if (currentIndex >= objetos.Length)
            {
                currentIndex = 0;
            }
            Deactivateall();
            ActivateByIndex(currentIndex);
        }
        if (currentIndex < -1)
        {
            currentIndex++;
        }
        
    }

    void Deactivateall()
    {
        //desactivar todos los elementos del array
        for (int i = 0; i < objetos.Length; i++)
        {
            objetos[i].SetActive(false);
        }


    }
    void ActivateByIndex(int index)
    {
        objetos[index].SetActive(true);
    }
}
