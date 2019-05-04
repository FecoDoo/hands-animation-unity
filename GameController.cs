using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private bool isActive;
    public bool isActiveLeft;
    public bool isActiveRight;
    // Start is called before the first frame update
    void Start()
    {
        this.isActive = false;
        this.isActiveLeft = false;
        this.isActiveRight = false;
        int[] array = new int[20];
    }

    // Update is called once per frame
    void Update ()
	{
            if (!isActive){
            this.isActive = true;
                if (Input.GetKeyDown (KeyCode.Space)) {
                    int n = 42;
                    GameObject.Find("LeftHandPrefab").SendMessage("getSenerio", n);
                    GameObject.Find("RightHandPrefab").SendMessage("getSenerio", n);
                }
            }
            // 只有当所有手动作都做完后才能设置为非占用状态
            if (!isActiveLeft && !isActiveRight){
                this.isActive = false;
            }
	}
    
}
