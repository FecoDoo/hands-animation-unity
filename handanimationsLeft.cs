using UnityEngine;
using System.Collections;

public class handanimationsLeft : MonoBehaviour
{
    Animator anim;
    int Idle = Animator.StringToHash("Idle");
    int Point = Animator.StringToHash("Point");
    int GrabLarge = Animator.StringToHash("GrabLarge");
    int GrabSmall = Animator.StringToHash("GrabSmall");
    int GrabStickUp = Animator.StringToHash("GrabStickUp");
    int GrabStickFront = Animator.StringToHash("GrabStickFront");
    int ThumbUp = Animator.StringToHash("ThumbUp");
    int Fist = Animator.StringToHash("Fist");
    int Gun = Animator.StringToHash("Gun");
    int GunShoot = Animator.StringToHash("GunShoot");
    int PushButton = Animator.StringToHash("PushButton");
    int Spread = Animator.StringToHash("Spread");
    int MiddleFinger = Animator.StringToHash("MiddleFinger");
    int Peace = Animator.StringToHash("Peace");
    int OK = Animator.StringToHash("OK");
	int Phone = Animator.StringToHash("Phone");
	int Rock = Animator.StringToHash("Rock");
	int Natural = Animator.StringToHash("Natural");
	int Number3 = Animator.StringToHash("Number3");
	int Number4 = Animator.StringToHash("Number4");
    

    void Start ()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
    }

    public void _Idle()
    {
        anim.SetTrigger(Idle);
    }

    public void _Point()
    {
        anim.SetTrigger(Point);
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
}