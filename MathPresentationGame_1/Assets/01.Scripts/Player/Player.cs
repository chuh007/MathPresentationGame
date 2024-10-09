using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{
    [field:SerializeField] public InputReader PlayerInput {  get; private set; }
    private Dictionary<Type, IPlayerComponent> _componets;
    public PlayerMovement MovementCompo { get; private set; }

    private void Awake()
    {
        _componets = new Dictionary<Type, IPlayerComponent>();

        GetComponentsInChildren<IPlayerComponent>().ToList()
            .ForEach(x=>_componets.Add(x.GetType(),x));

        _componets.Values.ToList().ForEach(compo => compo.Initialize(this));
        MovementCompo = GetComponent<PlayerMovement>();
    }
    private void Update()
    {
        MovementCompo.SetMoveMent(PlayerInput.Movement);
    }
}
