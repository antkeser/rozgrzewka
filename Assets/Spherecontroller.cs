using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spherecontroller : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    public float speed = 1000f;
    [SerializeField]
    TMP_Text endText;
    private void Start()
    {
        endText.gameObject.SetActive(false);
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontal, 0f, vertical)* speed * Time.deltaTime;
            rb.velocity = move;
    }

    private void omTriggerEnter(Collider other)
    {
        if (other.tag == "End")
        {
            endText.gameObject.SetActive(true);
        }
    }
}
