﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
	public class opencloseDoor1 : MonoBehaviour
	{

		public Animator openandclose1;
		public bool open;
		public Transform Player;

		void Start()
		{
			open = false;
		}

		public void Interactable()
		{
			if (Player)
			{
				float dist = 0;
				if (dist < 10)
				{
					if (open == false)
					{
						StartCoroutine(opening());
					}
					else
					{
						if (open == true)
						{
							StartCoroutine(closing());
						}

					}

				}
			}

		}

		IEnumerator opening()
		{
			print("you are opening the door");
			openandclose1.Play("Opening 1");
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			print("you are closing the door");
			openandclose1.Play("Closing 1");
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
}