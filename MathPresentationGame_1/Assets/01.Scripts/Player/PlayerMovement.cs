using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour, IPlayerComponent
{
    [Header("Setting")]

    [SerializeField] private float _moveSpeed = 5f;


    public Rigidbody2D _rbCompo { get; private set; }

    protected Vector2 movement;

    private Player _player;

    private void Awake()
    {
        _rbCompo = GetComponent<Rigidbody2D>();
    }
    public void SetMoveMent(Vector2 v)
    {
        movement = v;
    }
    public void Initialize(Player player)
    {
        _player = player;
    }
    private void FixedUpdate()
    {
        UpdateMovement();
    }

    private void UpdateMovement()
    {
        _rbCompo.velocity = movement*_moveSpeed;
        //_rbCompo.velocity = movement * _moveSpeed;
    }
}
