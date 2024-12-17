using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
	public class BRGlassDoor : MonoBehaviour
	{

		public Animator openandclose;
		public bool open;
		public Transform Player;

		void Start()
		{
			open = false;
		}

		public void Interactable(){
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
			print("you are opening");
			openandclose.Play("BRGlassDoorOpen");
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			print("you are closing");
			openandclose.Play("BRGlassDoorClose");
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
}