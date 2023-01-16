using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace greta
{
    public class RotCollection : MonoBehaviour
    {
        float rotSpeed = 0;
        void Start()
        {

        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0)) 
            {
                this.rotSpeed = 70;
            }

            transform.Rotate(0, 0, this.rotSpeed);

            this.rotSpeed *= 0.99f;
        }
    }
}


