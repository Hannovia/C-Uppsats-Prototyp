using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{

    public GameObject menu;
    private bool isShowing;

    public Vector2 moveInput;

    public Text[] options;

    public Color normalColor, highlightedColor;

    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            isShowing = !isShowing;
            menu.SetActive(isShowing);
        }

        if (Input.GetKeyDown("1"))
        {
            // Do something
        }

        if (Input.GetKeyDown("2"))
        {
            // Do something
        }

        if (menu.activeInHierarchy)
        {
            moveInput.x = Input.mousePosition.x - (Screen.width / 2f);
            moveInput.y = Input.mousePosition.y - (Screen.width / 2f);

            moveInput.Normalize();

            if (moveInput != Vector2.zero){
                float angle = Mathf.Atan2(moveInput.y, -moveInput.x) / Mathf.PI;
                angle *= 180;
                angle += 90f;
                if (angle < 0)
                {
                    angle += 360;
                }

                Debug.Log(angle);
            }
        }
    }
}
