using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    public int maxhit;
    public int timeshit;
    public Sprite[] hitSprites;
    private LevelManager levelManager;
	// Use this for initialization
	void Start () {
        timeshit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnCollisionEnter2D (Collision2D col)
    {
        timeshit++;
        if (timeshit >= maxhit)
        {
            Destroy(gameObject);
        }
        else
        {
            LoadSprites();
        }
    }

    void LoadSprites()
    {
        int spriteindex = timeshit-1;
        this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteindex];

    }

}
