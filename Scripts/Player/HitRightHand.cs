using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HitRightHand : MonoBehaviour
{
    public Animator anim;
    public Collider HitBox;
    public float DMG;
    private float DMGcarpani;
    [SerializeField] private float newHitted;

    void Start()
    {
        anim = GameObject.Find("RightHand").GetComponent<Animator>();
        DMG = -4;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            anim.SetBool("rightHiting", true);

        }
        else
        {
            anim.SetBool("rightHiting", false);
        }
        if (newHitted > 0)
        {
            newHitted -= 1 * Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("bişi girdi");
        if (other.tag == "Enemy" && newHitted<=0)
        {
            newHitted = 0.5f;
            other.gameObject.GetComponent<EnemyStats>().updateEnemyHP(DMG);
        }

    }
}
