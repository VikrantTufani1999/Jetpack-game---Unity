using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject PrevLHS;
    public GameObject PrevRHS;
    public GameObject LHS;
    public GameObject RHS;

    public GameObject player;

        // Start is called before the first frame update
    void Start()
    {

    }

 
    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y > RHS.transform.position.y)
        {
            var templeft = PrevLHS;
            var tempright = PrevRHS;
            PrevLHS = LHS;
            PrevRHS = RHS;
            templeft.transform.position += new Vector3(0 ,10, 0);
            tempright.transform.position += new Vector3(0, 10, 0);
            LHS = templeft;
            RHS = tempright;
        }
    }
}
