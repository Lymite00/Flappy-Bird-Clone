using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
   public GameObject pipePrefabs;
   public float heightValue;
   public Control birdcontrol;

   private void Start()
   {
      StartCoroutine(boruSpawner());
   }


   IEnumerator boruSpawner()
   {
      while (!birdcontrol.isDead)
      {
         Instantiate(pipePrefabs,new Vector3(5,Random.Range(heightValue,-heightValue)),quaternion.identity);
         yield return new WaitForSeconds(2f);
      }
   }
}
