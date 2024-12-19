using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{

	public class Drawer_Pull_X : MonoBehaviour
	{

		public Animator pull_01;
		public bool open;
		public Transform Player;

		void Start()
		{
			open = false;

        }

		public void Interact()
		{
			{
				if (Player)
				{
					float dist = 0;
					if (dist < 10)
					{
						//print("object name");
						print("Interacting with: " + gameObject.name);
						if (open == false)
						{
							StartCoroutine(opening());
							if (gameObject.name == "BottomPuller")
							{
                                PuzzleMan.Instance.UpdateDrawerState(true);
                            }
							else if(gameObject.name == "TopPuller")
							{
                                PuzzleMan.Instance.UpdateDrawerState(true);
                            }
							else if(gameObject.name == "MidDrawer")
							{
                                PuzzleMan.Instance.UpdateDrawerState(true);
                            }
                            else if (gameObject.name == "MidDrawer")
                            {
                                PuzzleMan.Instance.UpdateDrawerState(true);
                            }
                            else if (gameObject.name == "LargeDrawer")
                            {
                                PuzzleMan.Instance.UpdateDrawerState(true);
                            }
                            //LargeDrawer
                        }
                        else
						{
							if (open == true)
							{
								StartCoroutine(closing());
                                if (gameObject.name == "BottomPuller")
                                {
                                    PuzzleMan.Instance.UpdateDrawerState(false);
                                }
                                else if (gameObject.name == "TopPuller")
                                {
                                    PuzzleMan.Instance.UpdateDrawerState(false);
                                }
                                else if (gameObject.name == "MidDrawer")
                                {
                                    PuzzleMan.Instance.UpdateDrawerState(false);
                                }
                                else if (gameObject.name == "MidDrawer")
                                {
                                    PuzzleMan.Instance.UpdateDrawerState(false);
                                }
                                else if (gameObject.name == "LargeDrawer")
                                {
                                    PuzzleMan.Instance.UpdateDrawerState(false);
                                }
                            }

						}

					}
				}

			}

		}

		IEnumerator opening()
		{
			print("you are opening the door");
			pull_01.Play("openpull_01");
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			print("you are closing the door");
			pull_01.Play("closepush_01");
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
}