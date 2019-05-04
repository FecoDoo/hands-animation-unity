using UnityEngine;
using System.Collections;

public class handanimationsRight : MonoBehaviour
{
    Animator anim;
    public static int Idle = Animator.StringToHash("Idle");
    public static int Point = Animator.StringToHash("Point");
    public static int GrabLarge = Animator.StringToHash("GrabLarge");
    public static int GrabSmall = Animator.StringToHash("GrabSmall");
    public static int GrabStickUp = Animator.StringToHash("GrabStickUp");
    public static int GrabStickFront = Animator.StringToHash("GrabStickFront");
    public static int ThumbUp = Animator.StringToHash("ThumbUp");
    public static int Fist = Animator.StringToHash("Fist");
    public static int Gun = Animator.StringToHash("Gun");
    public static int GunShoot = Animator.StringToHash("GunShoot");
    public static int PushButton = Animator.StringToHash("PushButton");
    public static int Spread = Animator.StringToHash("Spread");
    public static int MiddleFinger = Animator.StringToHash("MiddleFinger");
    public static int Peace = Animator.StringToHash("Peace");
    public static int OK = Animator.StringToHash("OK");
	public static int Phone = Animator.StringToHash("Phone");
	public static int Rock = Animator.StringToHash("Rock");
	public static int Natural = Animator.StringToHash("Natural");
	public static int Number3 = Animator.StringToHash("Number3");
	public static int Number4 = Animator.StringToHash("Number4");
    public static int NewState = Animator.StringToHash("New State");



    void Start ()
    {
        anim = GetComponent<Animator>();
    }

    void Update(){}
    public void stop(int x){
        anim.ResetTrigger(x);
    }
    // public void start(){
    //     anim.Play();
    // }
    public void _Point()
    {
        anim.SetTrigger(Point);
    }
    public void _Idle()
    {
        anim.SetTrigger(Idle);
    }
    public void _GrabLarge()
    {
        anim.SetTrigger(GrabLarge);
    }
    public void _GrabSmall()
    {
        anim.SetTrigger(GrabSmall);
    }
    public void _GrabStickUp()
    {
        anim.SetTrigger(GrabStickUp);
    }
    public void _GrabStickFront()
    {
        anim.SetTrigger(GrabStickFront);
    }
    public void _ThumbUp()
    {
        anim.SetTrigger(ThumbUp);
    }
    public void _Fist()
    {
        anim.SetTrigger(Fist);
    }
    public void _Gun()
    {
        anim.SetTrigger(Gun);
    }
    public void _GunShoot()
    {
        anim.SetTrigger(GunShoot);
    }
    public void _PushButton()
    {
        anim.SetTrigger(PushButton);
    }
    public void _Spread()
    {
        anim.SetTrigger(Spread);
    }
    public void _MiddleFinger()
    {
        anim.SetTrigger(MiddleFinger);
    }
    public void _Peace()
    {
        anim.SetTrigger(Peace);
    }
    public void _OK()
    {
        anim.SetTrigger(OK);
    }
    public void _Phone()
    {
        anim.SetTrigger(Phone);
    }
    public void _Rock()
    {
        anim.SetTrigger(Rock);
    }
    public void _Natural()
    {
        anim.SetTrigger(Natural);
    }
    public void _Number3()
    {
        anim.SetTrigger(Number3);
    }
    public void _Number4()
    {
        anim.SetTrigger(Number4);
    }
    public void _Test()
    {
        anim.SetTrigger(NewState);
    }
}