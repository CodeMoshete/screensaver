using UnityEngine;

public enum AvailableAnimations
{
    Enterprise,
    Defiant,
    Intrepid
}

public class PlayDefaultAnimation : MonoBehaviour
{
    public AvailableAnimations Animation;

	void Start ()
    {
        Animator anim = GetComponent<Animator>();

		switch(Animation)
        {
            case AvailableAnimations.Enterprise:
                anim.SetTrigger("Enterprise");
                break;
            case AvailableAnimations.Defiant:
                anim.SetTrigger("Defiant");
                break;
            case AvailableAnimations.Intrepid:
                anim.SetTrigger("Intrepid");
                break;
        }
	}
}
