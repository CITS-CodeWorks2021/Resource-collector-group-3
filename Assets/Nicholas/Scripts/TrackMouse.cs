using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMouse : MonoBehaviour
{
    public Camera playerCam;
    public ParticleSystem sparks;
    public LayerMask controlPlane;

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    void CheckInput()
    {
        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit)
            {
                //Debug.LogWarning("Clicked: " + hit.point);
                Vector3 TargetPos = playerCam.transform.position - hit.transform.position;
                sparks.transform.position = hit.point;

                sparks.Play();

            }
        }
    }


    

    }

