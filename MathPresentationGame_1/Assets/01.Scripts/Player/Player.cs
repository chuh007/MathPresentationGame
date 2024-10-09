using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [field:SerializeField] public InputReader PlayerInput {  get; private set; }

    public PlayerMovement MovementCompo { get; private set; }

    private void Awake()
    {
        MovementCompo = GetComponent<PlayerMovement>();
    }
    private void Update()
    {
        MovementCompo.SetMoveMent(PlayerInput.Movement);
    }
}
