using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMoveable
{
    // Définition que l'interface à besoin de cette fonction
    void Move();
}

public interface IDestroyable
{
    void DestroySelf();
}

public interface IShootable
{
    void Shoot();
}