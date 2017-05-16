using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Use this for initialization
    public int idPlayer;
    public float speed;
    public float xorigin;

    void Start()
    {
        xorigin = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        //method 1
        /*
        if (Input.touchCount > 0)
        {
            Touch myTouch = Input.GetTouch(idPlayer);

            //  Vector2 touchDeltaPosition = new Vector2(myTouch.position.x, ;
            Vector2 vo = Camera.main.ScreenToWorldPoint(myTouch.position);
            this.GetComponent<Rigidbody>().velocity = new Vector2(0, vo.y * speed * Time.deltaTime);
        }
        else
            this.GetComponent<Rigidbody>().velocity =Vector2.zero;
            */


        //method 2

        if (Input.touchCount > 0)
        {
            Touch myTouch = Input.GetTouch(idPlayer);
            Vector2 vo = Camera.main.ScreenToWorldPoint(myTouch.position);
            if (vo.y > 4.20f)
                vo = new Vector2(xorigin, 4.20f);
            else
                vo = new Vector2(xorigin, vo.y);
            if (vo.y < -4.20f)
                vo = new Vector2(xorigin, -4.20f);
            else
                vo = new Vector2(xorigin, vo.y);
            this.transform.position = new Vector2(vo.x, vo.y);

        }
    }
}
