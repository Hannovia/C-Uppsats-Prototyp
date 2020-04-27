using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{

    public GameObject menu;

    public Vector2 moveInput;

    public Text[] options;

    public Color normalColor, highlightedColor;

    public int selectedOption;

    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
    }

    public void SwitchText0()
    {
        // Play TTS
    }

    public void SwitchText1()
    {
        // Play TTS
    }

    public void Switchtext2()
    {
        // Play TTS
    }

    public void SwitchText3()
    {
        // Play TTS
    }

    public void SwitchText4()
    {
        // Play TTS
    }

    public void SwitchText5()
    {
        // Play TTS
    }

    public void SwitchText6()
    {
        // Play TTS
    }

    public void SwitchText7()
    {
        // Play TTS
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (menu.activeInHierarchy)
            {
                menu.SetActive(false);
            } else
            {
                menu.SetActive(true);
            }
        }

        if (Input.GetKeyDown("0"))
        {
            SwitchText0();
        }

        if (Input.GetKeyDown("1"))
        {
            SwitchText1();
        }

        if (menu.activeInHierarchy)
        {
            moveInput.x = Input.mousePosition.x - (Screen.width / 2f);
            moveInput.y = Input.mousePosition.y - (Screen.height / 2f);

            moveInput.Normalize();

            if (moveInput != Vector2.zero)
            {
                float angle = Mathf.Atan2(moveInput.y, -moveInput.x) / Mathf.PI;
                angle *= 180;
                angle += 90f;
                if (angle < 0)
                {
                    angle += 360;
                }

               // Debug.Log(angle);

                for (int i = 0; i < options.Length; i++)
                {
                    if (angle > i * 45 && angle < (i + 1) * 45)
                    {
                        options[i].color = highlightedColor;
                        selectedOption = i;
                    } else
                    {
                        options[i].color = normalColor;
                    }
                }

            }

            if (Input.GetMouseButton(0))
            {
                switch (selectedOption)
                {
                    case 0:
                        SwitchText0();
                        break;

                    case 1:
                        SwitchText1();
                        break;

                    case 2:
                        Switchtext2();
                        break;

                    case 3:
                        SwitchText3();
                        break;

                    case 4:
                        SwitchText4();
                        break;

                    case 5:
                        SwitchText5();
                        break;

                    case 6:
                        SwitchText6();
                        break;

                    case 7:
                        SwitchText7();
                        break;
                }

                menu.SetActive(false);
            }
        }
    }
}
