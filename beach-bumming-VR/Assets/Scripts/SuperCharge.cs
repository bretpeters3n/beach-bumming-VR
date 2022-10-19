using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperCharge : MonoBehaviour
{
    public GameObject preserverGlow;
    public Transform preserverTop;
    public Transform preserverBottom;

    private bool isGlowing = false;
    private bool glowCheck;
    public float preserverTopHeight;
    public float preserverBottomHeight;

    // Update is called once per frame
    private void Update()
    {
        preserverBottomHeight = preserverBottom.position.y;
        preserverTopHeight = preserverTop.position.y;

        if ((preserverTopHeight - preserverBottomHeight) < 0)
        {
            glowCheck = true;
        }
        else
        {
            glowCheck = false;
        }

        if (isGlowing != glowCheck)
        {
            isGlowing = glowCheck;

            if (isGlowing)
            {
                StartGlow();
            }
            else
            {
                EndGlow();
            }
        }
    }

    private void StartGlow()
    {
        preserverGlow.SetActive(true);
    }

    private void EndGlow()
    {
        preserverGlow.SetActive(false);
    }
}
