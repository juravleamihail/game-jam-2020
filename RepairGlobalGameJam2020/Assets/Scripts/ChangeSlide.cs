using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSlide : MonoBehaviour
{
    [SerializeField]
    private GameObject nextSlide;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1"))
        {
            nextSlide.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
