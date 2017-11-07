using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{

    enum States { cell, sheets_0, mirror, lock_0, cell_mirror, sheets_1, lock_1, freedom, corridor_0, stairs_0, floor, closet_door, corridor_1, stairs_1, in_closet, corridor_2, stairs_2, corridor_3, courtyard }

    public Text myText;
    States myState;

    // Use this for initialization
    void Start()
    {
        //Initialize myState to cell
        myState = States.cell;
    }

    // Update is called once per frame
    void Update()
    {
        if (myState == States.cell) { Cell(); }
        else if (myState == States.sheets_0) { Sheets_0(); }
        else if (myState == States.lock_0) { Lock_0(); }
        else if (myState == States.mirror) { Mirror(); }
        else if (myState == States.cell_mirror) { Cell_Mirror(); }
        else if (myState == States.sheets_1) { Sheets_1(); }
        else if (myState == States.lock_1) { Lock_1(); }
        else if (myState == States.corridor_0) { Corridor_0(); }
        else if (myState == States.corridor_1) { Corridor_1(); }
        else if (myState == States.corridor_2) { Corridor_2(); }
        else if (myState == States.corridor_3) { Corridor_3(); }
        else if (myState == States.stairs_0) { Stairs_0(); }
        else if (myState == States.stairs_1) { Stairs_1(); }
        else if (myState == States.stairs_2) { Stairs_2(); }
        else if (myState == States.closet_door) { Closet_Door(); }
        else if (myState == States.in_closet) { In_Closet(); }
        else if (myState == States.courtyard) { Courtyard(); }
        else if (myState == States.floor) { Floor(); }
    }

    void Cell()
    {
        myText.text = "You are in a prison cell, and you want to escape. \nThere are some dirty sheets, " +
           "a mirror on the wall, and the door is locked from the outside.\n\n" +
           "Press S to view the sheets, M to view the mirror and L to view the Lock.";

        if (Input.GetKeyDown("s")) { myState = States.sheets_0; }
        else if (Input.GetKeyDown("m")) { myState = States.mirror; }
        else if (Input.GetKeyDown("l")) { myState = States.lock_0; ; }
    }

    void Sheets_0()
    {
        myText.text = "These sheets are very dirty! I guess you would expect that" +
            "from a prison. Hopefully they are changed soon!" +
            "\n\npress R to return back to the middle of the cell";

        if (Input.GetKeyDown("r")) { myState = States.cell; }
    }

    void Lock_0()
    {
        myText.text = "This is one of those button locks. You " +
            "have no idea what the combination is. You wish you" +
            "could somehow see where the dirty fingerprints were" +
            "\n\nPress R to return back to the middle of the cell";

        if (Input.GetKeyDown("r")) { myState = States.cell; }
    }

    void Mirror()
    {
        myText.text = "That dirty old mirror on the wall seems loose!" +
            "\n\nPress T to take the mirror, or R to return to the middle" +
            "of the cell.";

        if (Input.GetKeyDown("t")) { myState = States.cell_mirror; }
        else if (Input.GetKeyDown("r")) { myState = States.cell; }
    }

    void Cell_Mirror()
    {
        myText.text = "You are still in your cell and you still want to" +
            "escape! There are still some dirty sheets on the bed and the " +
            "cell door, which is firmly locked! " +
            "\n\nPress S to view the sheets, L to view the lock.";

        if (Input.GetKeyDown("s")) { myState = States.sheets_1; }
        else if (Input.GetKeyDown("l")) { myState = States.lock_1; }
    }

    void Sheets_1()
    {
        myText.text = "Holding a mirror in your hand, won't make the sheets" +
            "look any better and cleaner!" +
            "\n\nPress R to return back to the middle of the cell.";

        if (Input.GetKeyDown("r")) { myState = States.cell_mirror; }
    }

    void Lock_1()
    {
        myText.text = "You carefully put the mirror through the bars, and turn it around" +
            " to see the lock. You can now see the fingerprints on the buttons" +
            "You press the firty buttons, and hear a click!!!" +
            "\n\nPress O to open, R to return back to the cell.";

        if (Input.GetKeyDown("o")) { myState = States.corridor_0; }
        if (Input.GetKeyDown("r")) { myState = States.cell_mirror; }

    }

    void Corridor_0()
    {
        myText.text = "You are now in the corridor. Press S to go to the stairs, F to check the floor, C to check the closet door.!";

        if (Input.GetKeyDown("s")) { myState = States.stairs_0; }
        if (Input.GetKeyDown("f")) { myState = States.floor; }
        if (Input.GetKeyDown("c")) { myState = States.closet_door; }
    }

    void Stairs_0()
    {
        myText.text = "You start walking up the stairs towards the outside light. " +
           "You realise it's not break time, and you'll be caught immediately. " +
           "You slither back down the stairs and reconsider.\n\n Press R to go back to the corridor.";

        if (Input.GetKeyDown("r")) { myState = States.corridor_0; }
    }

    void Floor()
    {
        myText.text = "Rummaging around on the dirty floor, you find a hairclip." +
            "\n\nPress R to return to the corridor, N to go to the next corridor.";

        if (Input.GetKeyDown("r")) { myState = States.corridor_0; }
        if (Input.GetKeyDown("n")) { myState = States.corridor_1; }
    }

    void Closet_Door()
    {
        myText.text = "You are looking at a closet door, unfortunately it's locked. " +

        "Maybe you could find something around to help enourage it open?" +
        "\n\nPress R to return to the corridor";

        if (Input.GetKeyDown("r")) { myState = States.corridor_0; }
    }

    void Corridor_1()
    {
        myText.text = "Still in the corridor. Floor still dirty. Hairclip in hand. " +
        "Now what? You wonder if that lock on the closet would succumb to " +
        "to some lock-picking?" +
        "\n\nPress S to go up the stairs, press C to go to closet.";

        if (Input.GetKeyDown("s")) { myState = States.corridor_0; }
        if (Input.GetKeyDown("c")) { myState = States.in_closet; }
    }

    void Stairs_1()
    {
        myText.text = "You start walking up the stairs towards the outside light. " +
           "You realise it's not break time, and you'll be caught immediately. " +
           "You slither back down the stairs and reconsider.\n\n Press R to go back to the corridor.";

        if (Input.GetKeyDown("r")) { myState = States.corridor_0; }
    }

    void In_Closet()
    {
        myText.text = "Inside the closet you see a cleaner's uniform that looks about your size! " +
           "Seems like your day is looking-up." +
           "\n\nPress C to go to the second corridor, press N to go to the third corridor.";

        if (Input.GetKeyDown("s")) { myState = States.corridor_2; }
        if (Input.GetKeyDown("n")) { myState = States.corridor_3; }
    }

    void Corridor_2()
    {
        myText.text = "You are inside the second corridor." +
           "\n\nPress S to go up the stairs, press E to return to the closet.";

        if (Input.GetKeyDown("s")) { myState = States.stairs_2; }
        if (Input.GetKeyDown("e")) { myState = States.in_closet; }
    }

    void Stairs_2()
    {
        myText.text = "You start walking up the stairs towards the outside light. " +
          "You realise it's not break time, and you'll be caught immediately. " +
          "You slither back down the stairs and reconsider." +
          "\n\n Press R to go back to the corridor.";

        if (Input.GetKeyDown("r")) { myState = States.corridor_2; }
    }

    void Corridor_3()
    {
        myText.text = "You're standing back in the corridor, now convincingly dressed as a cleaner. " +
            "You strongly consider the run for freedom." +
            "\n\nPress R to return to the closet, press c to go to the courtyard";

        if (Input.GetKeyDown("r")) { myState = States.in_closet; }
        if (Input.GetKeyDown("c")) { myState = States.courtyard; }
    }

    void Courtyard()
    {
        myText.text = "You walk through the courtyard dressed as a cleaner. " +
                "The guard tips his hat at you as you waltz past, claiming " +
        "your freedom. You heart races as you walk into the sunset.\n\n" +
        "Press P to Play again.";
        if (Input.GetKeyDown("p")) { myState = States.cell; }
    }
}
