using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonMotherController : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //animator.SetBool("breatheFire", true);
        StartCoroutine(Waiter());
    }

    // Update is called once per frame
    void Update()
    {
    }

	IEnumerator Waiter()
	{
        yield return new WaitForSeconds(5);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(5);

        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(5);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(5);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(5);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(5);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(5);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(5);
        animator.SetBool("breatheFire", true);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(5);
        animator.SetBool("breatheFire", true);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(5);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(5);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(5);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(5);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(5);
        yield return new WaitForSeconds(5);
        yield return new WaitForSeconds(5);

        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
        animator.SetBool("breatheFire", true);
        yield return new WaitForSeconds(10);
    }
}
