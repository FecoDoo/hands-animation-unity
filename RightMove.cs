using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RightMove : MonoBehaviour
{
    private GameController gameController;
    protected handanimationsRight hr;
    //protected Animator hr_animator;
	protected Transform origin;   //得到cube的transform
    protected bool isActive;
    public Transform pointer;
    protected Vector3 middle;
    // Start is called before the first frame update
    private int senerio;
    private Vector3 standUp;
    private Vector3 flat;
    void Start()
    {
        this.origin = this.transform;
        DOTween.Init();
        this.isActive = false;
        this.middle = new Vector3(0,0.6f,0.6f);
        this.standUp = new Vector3(0,0,-90);
        this.flat = new Vector3(0,0,-180);
        this.senerio = 0;
        hr =  GameObject.Find("RightHand").GetComponent<handanimationsRight>();
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>(); 

    }

    // Update is called once per frame
    void Update()
    {
        if (!gameController.isActiveRight) {
            Animation(senerio);
        } else {} 
    }
    void Animation(int para){
        Sequence mySequence = DOTween.Sequence();
        switch(para){
            case 0:
                break;
            case 1:
                SetActive(true);
                hr._Point();
                mySequence.Append(transform.DORotate(this.flat,0.1f,RotateMode.WorldAxisAdd));
                ScaleUp(mySequence);
                mySequence.Append(transform.DOMove(new Vector3(0.6f,0.2f,0.6f),0.3f));
                mySequence.AppendInterval(0.2f);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                
                break;
            case 2:

                break;
            case 3:
                SetActive(true);
                hr._Idle();
                mySequence.Append(transform.DOMove(new Vector3(0.1f,0.6f,0.6f),0.1f));
                mySequence.Append(transform.DORotate(new Vector3(-90,0,-180),0.1f,RotateMode.WorldAxisAdd));
                ScaleUp(mySequence,2);
                mySequence.AppendInterval(0.5f);
                mySequence.Append(transform.DOMove(origin.position,1));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);

                break;
            case 4:
                SetActive(true);
                hr._Gun();
                mySequence.Append(transform.DOMove(new Vector3(0.15f,0.6f,0.6f),0.1f));
                mySequence.Append(transform.DOLookAt(new Vector3(0,0.35f,0.8f),0.1f));
                ScaleUp(mySequence,2);
                mySequence.AppendInterval(1);
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);

                break;
            case 5:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(-15,180,0),0.1f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(new Vector3(0,1.25f,0.6f),0.1f));
                hr._Idle();
                ScaleUp(mySequence,2);
                mySequence.Append(transform.DOMove(new Vector3(0,1.25f,0.7f),0.1f));
                mySequence.Append(transform.DOMove(new Vector3(0,1.25f,0.6f),0.1f));
                mySequence.Append(transform.DOMove(new Vector3(0,1.25f,0.7f),0.1f));
                mySequence.Append(transform.DOMove(new Vector3(0,1.25f,0.6f),0.1f));
                mySequence.Append(transform.DOMove(new Vector3(0,1.25f,0.7f),0.1f));
                mySequence.Append(transform.DOMove(new Vector3(0,1.25f,0.6f),0.1f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);

                break;
            case 6:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(-20f,-85f,-1.6f),0.1f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(new Vector3(0.4f,1.08f,0.34f),0.1f));
                hr._Idle();
                ScaleUp(mySequence,2);        
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 7:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(-90,0,0),0.1f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(new Vector3(0.6f,1.05f,0.6f),0.1f));
                hr._Idle();
                ScaleUp(mySequence,2);
                mySequence.Append(transform.DORotate(new Vector3(0,0,20),0.2f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DORotate(new Vector3(0,0,-20),0.2f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DORotate(new Vector3(0,0,20),0.2f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DORotate(new Vector3(0,0,-20),0.2f,RotateMode.WorldAxisAdd));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 8:
                SetActive(true);
                mySequence.Append(transform.DORotate(this.standUp,0.1f,RotateMode.WorldAxisAdd));
                hr._ThumbUp();
                ScaleUp(mySequence,2);
                mySequence.AppendInterval(1);
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 9:
                SetActive(true);
                mySequence.Append(transform.DORotate(-this.standUp,0.1f,RotateMode.WorldAxisAdd));
                hr._ThumbUp();
                ScaleUp(mySequence,2);
                mySequence.AppendInterval(1);
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 10:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(0,-90,0),0.1f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(new Vector3(0,0.85f,0.6f),0.1f));
                ScaleUp(mySequence,2);
                mySequence.AppendInterval(1);
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 11:
                SetActive(true);
                hr._Natural();
                mySequence.Append(transform.DORotate(this.standUp,0.1f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(new Vector3(0.25f,0.6f,0.6f),0.1f));
                ScaleUp(mySequence,2);
                mySequence.Append(transform.DOMove(new Vector3(0.3f,1,1),0.2f));
                mySequence.AppendInterval(1);
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 12:
                SetActive(true);
                hr._Phone();
                mySequence.Append(transform.DOMove(new Vector3(0.25f,0.6f,0.6f),0.1f));
                ScaleUp(mySequence,2);
                mySequence.Append(transform.DORotate(new Vector3(0,-135,0),0.3f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DORotate(new Vector3(0,135,0),0.3f,RotateMode.WorldAxisAdd));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 13:
                SetActive(true);
                hr._Fist();
                mySequence.Append(transform.DORotate(this.standUp,0.3f,RotateMode.WorldAxisAdd));
                ScaleUp(mySequence,2);
                mySequence.Append(transform.DOMove(new Vector3(0.6f,0.4f,1),0.2f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 14:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(0,-90,0),0.3f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(this.middle,0.2f));
                hr._Phone();
                ScaleUp(mySequence,2);
                mySequence.Append(transform.DOMove(new Vector3(0,0.6f,1),0.2f));
                mySequence.Append(transform.DOMove(this.middle,0.2f));
                mySequence.Append(transform.DOMove(new Vector3(0,0.6f,1),0.2f));
                mySequence.Append(transform.DOMove(this.middle,0.2f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 15:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(-30,-90,-76),0.1f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(new Vector3(0.1f,0.85f,0.6f),0.1f));
                hr._GunShoot();
                ScaleUp(mySequence,2);
                mySequence.Append(transform.DOMove(new Vector3(0.1f,0.8f,0.6f),0.2f));
                mySequence.Append(transform.DOMove(new Vector3(0.1f,0.85f,0.6f),0.2f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 16:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(0,0,-90),0.1f,RotateMode.WorldAxisAdd));
                hr._ThumbUp();
                ScaleUp(mySequence,2);
                mySequence.AppendInterval(1);
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 17:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(-90,0,0),0.1f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(new Vector3(0.6f,1,0.6f),0.1f));
                hr._Spread();
                ScaleUp(mySequence,2);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                ScaleDown(mySequence);
                mySequence.AppendCallback(callback);
                break;
            case 18:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(0,-90,0),0.1f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(new Vector3(0.6f,1,0.6f),0.1f));
                hr._Spread();
                ScaleUp(mySequence,2);
                hr._Natural();
                mySequence.Append(transform.DOMove(middle,0.5f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                
                mySequence.AppendCallback(callback);
                break;
            case 19:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(-90,0,0),0.1f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(new Vector3(0.6f,1,0.6f),0.1f));
                ScaleUp(mySequence,2);
                hr._Point();
                mySequence.Append(transform.DORotate(new Vector3(0,-180,0),0.3f,RotateMode.WorldAxisAdd));
                hr._Peace();
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 20:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(0,-90,180),0.1f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(new Vector3(0.2f,0.6f,0.6f),0.1f));
                ScaleUp(mySequence,2);
                hr._Natural();
                mySequence.Append(transform.DOMove(new Vector3(0.2f,1,0.6f),0.5f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 21:
                SetActive(true);
                mySequence.Append(transform.DOLookAt(middle,0.1f));
                mySequence.Append(transform.DORotate(new Vector3(90,0,0),0.1f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(new Vector3(0.6f,0.6f,0.6f),0.1f));
                ScaleUp(mySequence,2);
                hr._Phone();
                mySequence.Append(transform.DOMove(new Vector3(0.2f,0.6f,0.6f),0.5f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 22:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(0,0,-90),0.1f,RotateMode.WorldAxisAdd));
                ScaleUp(mySequence,2);
                hr._Phone();
                mySequence.Append(transform.DOMove(new Vector3(0.6f,0.6f,1),0.5f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 23:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(0,90,0),0.1f,RotateMode.WorldAxisAdd));
                ScaleUp(mySequence,2);
                hr._Idle();
                mySequence.Append(transform.DOMove(new Vector3(0,0.6f,1),0.2f));
                mySequence.Append(transform.DOLookAt(new Vector3(0.6f,0.6f,20),0.2f));
                mySequence.Append(transform.DOMove(new Vector3(-0.6f,0.6f,0.6f),0.2f));
                mySequence.Append(transform.DOLookAt(new Vector3(-2,0.6f,0.6f),0.2f));
                //mySequence.Append(transform.DOPath(Vector3[(0,0.6f,0.6f),(-0.6f,0.6f,0.6f)],1,Linear,Full3D,10,null));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 24:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(-90,-90,0),0.1f,RotateMode.WorldAxisAdd));
                ScaleUp(mySequence,2);
                hr._OK();
                mySequence.Append(transform.DOMove(new Vector3(0.4f,0.2f,0.6f),0.5f));
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOMove(new Vector3(0.4f,0.2f,0.6f),0.5f));
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 25:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(-14f,-99f,-76f),0.1f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(new Vector3(0.09f,0.6f,0.6f),0.1f));
                ScaleUp(mySequence,2);
                hr._Peace();
                mySequence.Append(transform.DOMove(new Vector3(0.09f,0.85f,0.6f),0.3f));
                mySequence.Append(transform.DOMove(new Vector3(0.09f,0.6f,0.6f),0.1f));
                mySequence.Append(transform.DOMove(new Vector3(0.09f,0.85f,0.6f),0.3f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 26:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(-14f,-99f,-76f),0.1f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(new Vector3(0.09f,0.7f,0.6f),0.1f));
                ScaleUp(mySequence,2);
                hr._GrabStickFront();
                mySequence.Append(transform.DOMove(new Vector3(0.09f,0.85f,0.6f),0.2f));
                mySequence.Append(transform.DOMove(new Vector3(0.09f,0.7f,0.6f),0.1f));
                mySequence.Append(transform.DOMove(new Vector3(0.09f,0.85f,0.6f),0.2f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 27:
                SetActive(true);
                hr._Idle();
                mySequence.Append(transform.DOMove(new Vector3(0.25f,0.6f,0.6f),0.05f));
                mySequence.Append(transform.DOLookAt(middle,0.05f));
                mySequence.Append(transform.DORotate(new Vector3(-180,0,0),0.05f,RotateMode.WorldAxisAdd));
                ScaleUp(mySequence,2);
                mySequence.Append(transform.DOMove(new Vector3(0.25f,0.8f,0.6f),0.5f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 28:
                SetActive(true);
                hr._Point();
                mySequence.Append(transform.DORotate(new Vector3(0,0,-90),0.05f,RotateMode.WorldAxisAdd));
                ScaleUp(mySequence,2);
                mySequence.Append(transform.DOMove(new Vector3(0.6f,0.6f,1f),0.15f));
                mySequence.Append(transform.DOMove(origin.position,0.15f));
                mySequence.Append(transform.DOMove(new Vector3(0.6f,0.6f,1f),0.15f));
                mySequence.Append(transform.DOMove(origin.position,0.15f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 29:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(-90,0,20),0.1f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(new Vector3(0.4f,1,0.3f),0.1f));
                ScaleUp(mySequence,2);
                hr._Peace();
                mySequence.Append(transform.DORotate(new Vector3(0,0,-60),0.4f,RotateMode.WorldAxisAdd));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 30:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(-90,0,0),0.1f,RotateMode.WorldAxisAdd));
                ScaleUp(mySequence,2);
                hr._Natural();
                hr._Fist();
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 31:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(-90,-90,0),0.1f,RotateMode.WorldAxisAdd));
                ScaleUp(mySequence,2);
                hr._Natural();
                mySequence.Append(transform.DOMove(new Vector3(0.1f,0.6f,0.6f),0.5f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 32:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(0,0,-90),0.1f,RotateMode.WorldAxisAdd));
                ScaleUp(mySequence,2);
                hr._ThumbUp();
                mySequence.Append(transform.DOMove(new Vector3(0.1f,0.6f,0.6f),0.5f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
        }
    }

    // -----------------------------------------------------------------------------
    void ScaleUp(Sequence n, int scale = 3) => n.Append(transform.DOScale(new Vector3(scale, scale, scale), 0.2f));
    void ScaleDown(Sequence n, int scale = 1) => n.Append(transform.DOScale(new Vector3(scale, scale, scale), 0.2f));
    // Set the object avaluable again
    void callback(){
        hr._Idle();
        SetActive(false);
        this.senerio = 0;
    }
    void SetActive(bool para) => gameController.isActiveRight = para;
    void getSenerio(int n)
	{
        // 获取当前场景值
		this.senerio = n;
	}
}
