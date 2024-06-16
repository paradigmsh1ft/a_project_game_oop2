using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    [SerializeField] Transform weaponCollider;

    private ActiveInstrument activeInstrument;
    private Animator animator;
    private PlayerControls playerControls;
    private PlayerController playerController;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        playerControls = new PlayerControls();
        playerController = GetComponentInParent<PlayerController>();
        activeInstrument = GetComponentInParent<ActiveInstrument>();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void Start()
    {
        playerControls.FightSystem.SwordAttack.started += _ => Attack();
    }

    private void Update()
    {

        
    }
    private void Attack()
    {
        animator.SetTrigger("SwordAttack");
        weaponCollider.gameObject.SetActive(true);
    }

    public void AttackEnd()
    {
        weaponCollider.gameObject.SetActive(false);
    }

}
