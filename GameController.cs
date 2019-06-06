using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private int n;
    private bool isActive;
    private AndroidJavaClass unityPlayer;
    private AndroidJavaObject activity;
    public bool isActiveLeft;
    public bool isActiveRight;
    // Start is called before the first frame update
    void Start()
    {
        this.unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        this.activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        this.isActive = false;
        this.isActiveLeft = false;
        this.isActiveRight = false;
        int[] array = new int[20];
        this.n = 50;
    }

    // Update is called once per frame
    void Update ()
	{
            if (!isActive){
                this.isActive = true;
                if (this.n > 0){
                    this.ChangeParams();
                } else {
                    Application.Quit();
                }
            }
            // 只有当所有手动作都做完后才能设置为非占用状态
            if (!isActiveLeft && !isActiveRight){
                this.isActive = false;
            }

	}

    void ChangeParams(){
        GameObject.Find("LeftHandPrefab").SendMessage("getSenerio", n);
        GameObject.Find("RightHandPrefab").SendMessage("getSenerio", n);
        this.n -= 1;
    }
    
}
