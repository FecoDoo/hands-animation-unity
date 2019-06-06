using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LeftMove : MonoBehaviour
{
    private GameController gameController;
    protected handanimationsLeft hl;
	protected Transform origin;   //得到cube的transform
    protected bool isActive;
    protected Vector3 middle;
    public Transform pointer;
    private int senerio;

    // Start is called before the first frame update
    void Start()
    {
        this.origin = this.transform;
        DOTween.Init();
        //this.isActive = false;
        this.middle = new Vector3(0,0.6f,0.6f);
        this.senerio = 0;
        hl =  GameObject.Find("LeftHand").GetComponent<handanimationsLeft>();
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameController.isActiveLeft) {
            Animation(senerio);
        } else {}
    }
    void Animation(int para){
        Sequence mySequence = DOTween.Sequence();
        switch(para){
            case 2:
                SetActive(true);
                hl._Point();
                mySequence.Append(transform.DOMove(middle,0.1f));
                mySequence.Append(transform.DORotate(new Vector3(-30,180,0),0.1f,RotateMode.WorldAxisAdd));
                ScaleUp(mySequence,2);
                mySequence.AppendInterval(1);
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                
                break;
            case 3:
                SetActive(true);
                hl._Idle();
                mySequence.Append(transform.DOMove(new Vector3(-0.1f,0.6f,0.6f),0.1f));
                mySequence.Append(transform.DORotate(new Vector3(-90,0,180),0.1f,RotateMode.WorldAxisAdd));
                ScaleUp(mySequence,2);
                mySequence.AppendInterval(0.5f);
                mySequence.Append(transform.DOMove(origin.position,1));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);

                break;
            case 4:
                SetActive(true);
                hl._Gun();
                mySequence.Append(transform.DOMove(new Vector3(-0.15f,0.6f,0.6f),0.1f));
                mySequence.Append(transform.DOLookAt(new Vector3(0,0.35f,0.8f),0.1f));
                ScaleUp(mySequence,2);
                mySequence.AppendInterval(1);
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 11:
                SetActive(true);
                hl._Natural();
                mySequence.Append(transform.DORotate(new Vector3(0,0,90),0.1f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(new Vector3(-0.25f,0.6f,0.6f),0.1f));
                ScaleUp(mySequence,2);
                mySequence.Append(transform.DOMove(new Vector3(-0.3f,1,1),0.2f));
                mySequence.AppendInterval(1);
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 12:
                SetActive(true);
                hl._Phone();
                mySequence.Append(transform.DOMove(new Vector3(-0.25f,0.6f,0.6f),0.1f));
                ScaleUp(mySequence,2);
                mySequence.Append(transform.DORotate(new Vector3(0,135,0),0.3f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DORotate(new Vector3(0,-135,0),0.3f,RotateMode.WorldAxisAdd));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 20:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(0,90,180),0.1f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(new Vector3(-0.2f,0.6f,0.6f),0.1f));
                ScaleUp(mySequence,2);
                hl._Natural();
                mySequence.Append(transform.DOMove(new Vector3(-0.2f,1,0.6f),0.5f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 21:
                SetActive(true);
                mySequence.Append(transform.DOLookAt(middle,0.1f));
                mySequence.Append(transform.DORotate(new Vector3(90,0,0),0.1f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(new Vector3(-0.6f,0.6f,0.6f),0.1f));
                ScaleUp(mySequence,2);
                hl._Phone();
                mySequence.Append(transform.DOMove(new Vector3(-0.2f,0.6f,0.6f),0.5f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 24:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(-90,90,0),0.1f,RotateMode.WorldAxisAdd));
                ScaleUp(mySequence,2);
                hl._OK();
                mySequence.Append(transform.DOMove(new Vector3(-0.4f,0.2f,0.6f),0.5f));
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOMove(new Vector3(-0.4f,0.2f,0.6f),0.5f));
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 27:
                SetActive(true);
                hl._Idle();
                mySequence.Append(transform.DOMove(new Vector3(-0.25f,0.6f,0.6f),0.05f));
                mySequence.Append(transform.DOLookAt(middle,0.05f));
                mySequence.Append(transform.DORotate(new Vector3(-180,0,0),0.05f,RotateMode.WorldAxisAdd));
                ScaleUp(mySequence,2);
                mySequence.Append(transform.DOMove(new Vector3(-0.25f,0.8f,0.6f),0.5f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 31:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(-90,90,0),0.1f,RotateMode.WorldAxisAdd));
                ScaleUp(mySequence,2);
                hl._Natural();
                mySequence.Append(transform.DOMove(new Vector3(-0.1f,0.6f,0.6f),0.5f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 32:
                SetActive(true);
                mySequence.Append(transform.DORotate(new Vector3(0,0,90),0.1f,RotateMode.WorldAxisAdd));
                ScaleUp(mySequence,2);
                hl._ThumbUp();
                mySequence.Append(transform.DOMove(new Vector3(-0.1f,0.6f,0.6f),0.5f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 36:
                SetActive(true);
                hl._ThumbUp();
                mySequence.Append(transform.DORotate(new Vector3(0,0,90),0.1f,RotateMode.WorldAxisAdd));
                ScaleUp(mySequence,2);
                mySequence.Append(transform.DOMove(new Vector3(-0.4f,0.6f,1),0.5f));
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 44:
                SetActive(true);
                hl._Idle();
                mySequence.Append(transform.DORotate(new Vector3(0,90,0),0.05f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(new Vector3(0,0.6f,0.6f),0.05f));
                ScaleUp(mySequence,2);
                mySequence.AppendInterval(1.8f);
                ScaleDown(mySequence);
                mySequence.Append(transform.DOMove(origin.position,0.1f));
                mySequence.Append(transform.DOLookAt(pointer.position,0.1f));
                mySequence.AppendCallback(callback);
                break;
            case 45:
                SetActive(true);
                hl._Idle();
                mySequence.Append(transform.DORotate(new Vector3(-90,180,0),0.05f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DORotate(new Vector3(0,0,-40),0.05f,RotateMode.WorldAxisAdd));
                mySequence.Append(transform.DOMove(new Vector3(-0.2f,1,0.4f),0.05f));
                ScaleUp(mySequence,2);
                mySequence.AppendInterval(1);
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
    void callback(){
        hl._Idle();
        SetActive(false);
        this.senerio = 0;
    }
    void SetActive(bool para) => gameController.isActiveLeft = para;
    void getSenerio(int n)
	{
        // 获取当前场景值
		this.senerio = n;
	}
}
