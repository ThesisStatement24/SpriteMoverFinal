using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{

    public GameObject Ship;
    public int Speed;
    public bool CanMove;

    // Start is called before the first frame update
    void Start()
    {
        CanMove = true;
        Speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(CanMove == true && Input.GetKey(KeyCode.UpArrow))
        {

            transform.position += Vector3.up * Speed * Time.deltaTime;

        }

        if (CanMove == true && Input.GetKey(KeyCode.DownArrow))
        {

            transform.position += Vector3.down * Speed * Time.deltaTime;

        }

        if (CanMove == true && Input.GetKey(KeyCode.LeftArrow))
        {

            transform.position += Vector3.left * Speed * Time.deltaTime;

        }

        if (CanMove == true && Input.GetKey(KeyCode.RightArrow))
        {

            transform.position += Vector3.right * Speed * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Speed = 3;

        } else
        {
            Speed = 1;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(0, 0, 0); 

        }

        if (CanMove == true && Input.GetKeyDown(KeyCode.P))
        {
            CanMove = false;

        } else if (CanMove == false && Input.GetKeyDown(KeyCode.P))
        {

            CanMove = true;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {

            Ship.SetActive(false);

        }

        
    }
}
