using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States {Cell, Cell_Mirror, Corridor_0, Lock_0, Lock_1, Mirror,
        Sheet_0, Sheet_1, Closet_Door, Floor, Stairs_0, Corridor_1, In_Closet,
        Stairs_1, Corridor_2, Corridor_3, Freedom};
    private States myState;

    void Start() {
        myState = States.Cell;
    }

    void Update() {
        switch(myState) {
            case States.Cell: cell(); break;
            case States.Cell_Mirror: cellMirror(); break;
            case States.Corridor_0: corridor0(); break;
            case States.Lock_0: lock0(); break;
            case States.Lock_1: lock1(); break;
            case States.Mirror: mirror(); break;
            case States.Sheet_0: sheet0(); break;
            case States.Sheet_1: sheet1(); break;
            case States.Closet_Door: closetDoor(); break;
            case States.Floor: floor(); break;
            case States.Stairs_0: stairs0(); break;
            case States.Corridor_1: corridor1(); break;
            case States.In_Closet: inCloset(); break;
            case States.Stairs_1: stairs1(); break;
            case States.Corridor_2: corridor2(); break;
            case States.Corridor_3: corridor3(); break;
            case States.Freedom: freedom(); break;
            default: break;
        }
    }

    void cell() {
        text.text = "You are in a prison cell, and you want to escape. " +
                    "There are some dirty sheets on the bed, a mirror on" +
                    " the wall, and the door is locked from the outside." +
                    "\n\nPress S to view Sheets, M to look at Mirror, " +
                    "and L to see Lock.";
        if (Input.GetKeyDown(KeyCode.S)) {
            myState = States.Sheet_0;
        } else if (Input.GetKeyDown(KeyCode.M)) {
            myState = States.Mirror;
        } else if (Input.GetKeyDown(KeyCode.L)) {
            myState = States.Lock_0;
        }
    }

    void sheet0() {
        text.text = "You can't believe you've been living in this shithole" +
                    " for nearly 18 months! Those sheets are disgusting!\n\n" +
                    "Press R to Return to roaming your cell.";
        if (Input.GetKeyDown(KeyCode.R))
            myState = States.Cell;

    }

    void mirror() {
        text.text = "You take a look at yourself in the mirror. Not good. " +
                    "You need a shave badly. As you look, you realise that " +
                    "the mirror is hanging loosely on the wall. \n\nPress R" + 
                    " to Return to roaming your cell, T to Take down the " +
                    "mirror from the wall.";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.Cell;
        } else if (Input.GetKeyDown(KeyCode.T)) {
            myState = States.Cell_Mirror;
        }
    }

    void lock0()  {
        text.text = "It's one of those pin locks. You crane your neck trying" +
                    " to make out something. Nope, nothing. 0000? Don't be " +
                    "daft. This game is easy, but not that easy. \n\nPress " +
                    "R to Return to roaming your cell.";
        if (Input.GetKeyDown(KeyCode.R))
            myState = States.Cell;
    }

    void cellMirror() {
        text.text = "You hold the mirror in your hands, not quite sure what " +
                    "to do with it. There's a light patch on the wall where " +
                    "the mirror used to hang, probably the only clean spot " +
                    "in the whole cell. You are still stuck in this hell of " +
                    "a place, there are still dirty sheets on your bed, and " +
                    "the prison door is still shut. \n\nPress S to view " +
                    "Sheets, and L to look at the Lock.";
        if (Input.GetKeyDown(KeyCode.S)) {
            myState = States.Sheet_1;
        } else if (Input.GetKeyDown(KeyCode.L)) {
            myState = States.Lock_1;
        }
    }

    void sheet1() {
        text.text = "You are half-tempted to wipe the mirror with your " +
                    "sheets, but you thought better. Those sheets can't " +
                    "clean anything. \n\nPress R to Return to roaming " +
                    "your cell.";
        if (Input.GetKeyDown(KeyCode.R))
            myState = States.Cell_Mirror;
    }

    void lock1() {
        text.text = "You hold the mirror out through the bars to look at the " +
                    "lock properly, but it drops to the ground! Not before " +
                    "you see the greasy fingerprints on the combination " +
                    "though. Yucks, those prison guards have got some dirty " +
                    "fingers...\n\nPress R to Return to your cell and give " +
                    "up on breaking out, press E to Escape.";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.Cell_Mirror;
        } else if (Input.GetKeyDown(KeyCode.E)) {
            myState = States.Corridor_0;
        }
    }

    void corridor0() {
        text.text = "You look at your fingers, slightly repulsed. But all's " +
                    "good now that you are out. You look around cautiously, " +
                    "but there's no one. A creepy stairwell is to the left, " +
                    "and there's a cleaning closet on the right. \n\nPress " +
                    "S to go up the Stairs , F to look mindlessly at the " +
                    "Floor and C to open the Closet door.";
        if (Input.GetKeyDown(KeyCode.S)) {
            myState = States.Stairs_0;
        } else if (Input.GetKeyDown(KeyCode.F)) {
            myState = States.Floor;
        } else if (Input.GetKeyDown(KeyCode.C)) {
            myState = States.Closet_Door;
        }
    }

    void closetDoor() {
        text.text = "The closet door is locked with a padlock. Did you " +
                    "expect to see the key in the keyhole? Nope, not there." +
                    "\n\nPress R to Return to the corridor.";
        if (Input.GetKeyDown(KeyCode.R))
            myState = States.Corridor_0;
    }

    void floor() {
        text.text = "You see a shiny reflection of what appears to be a " +
                    "cheaply made hairclip. \n\nPress H to pick up the " +
                    "Hairclip, and press R to Return to the corridor.";
        if (Input.GetKeyDown(KeyCode.H)) {
            myState = States.Corridor_1;
        } else if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.Corridor_0;
        }
    }

    void stairs0() {
        text.text = "You hear faint sounds from the top of the staircase. " +
                    "Perhaps this isn't such a good idea... \n\nPress R to " +
                    "Return to the corridor.";
        if (Input.GetKeyDown(KeyCode.R))
            myState = States.Corridor_0;
    }

    void corridor1() {
        text.text = "What can you do with a flimsy, dirty hairpin? Some..." +
                    "lock-picking? \n\nPress P to Pick the closet door lock," +
                    " press S to climb the Stairs.";
        if (Input.GetKeyDown(KeyCode.P)) {
            myState = States.In_Closet;
        } else if (Input.GetKeyDown(KeyCode.S)) {
            myState = States.Stairs_1;
        }
    }

    void inCloset() {
        text.text = "After a few minutes of hard work you finally got it to " +
                    "open! Of course, you aren't in the prison for nothing. " +
                    "The closet is empty except for a broom and a set of " +
                    "uniform for the janitor. \n\nPress R to Return to the " +
                    "corridor, or press D to Dress up as a janitor.";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.Corridor_2;
        } else if (Input.GetKeyDown(KeyCode.D)) {
            myState = States.Corridor_3;
        }
    }

    void stairs1() {
        text.text = "You perk your ears but don't hear anything. Perhaps " +
                    "it's safe now. You start trudging up the stairs. Uh " +
                    "oh, footsteps!\n\nPress R to Return to the corridor.";
        if (Input.GetKeyDown(KeyCode.R))
            myState = States.Corridor_1;
    }

    void corridor2() {
        text.text = "Well well, what should you do now? \n\nPress S to " +
                    "climb up the Stairs, or press C to return to the " +
                    "Closet.";
        if (Input.GetKeyDown(KeyCode.S)) {
            myState = States.Stairs_1;
        }
        else if (Input.GetKeyDown(KeyCode.D)) {
            myState = States.In_Closet;
        }
    }

    void corridor3() {
        text.text = "The uniform actually looks good on you! Perhaps you " +
                    "should consider changing your profession! \n\nPress S " +
                    "to head up the Stairs";
        if (Input.GetKeyDown(KeyCode.S))
            myState = States.Freedom;
    }

    void freedom() {
        text.text = "You are in the courtyard now, and curiously there are " +
                    "no guards up and about. How convenient! You take in a " +
                    "breath of fresh air... Ugh. The sooner you are out of " +
                    "here the better. You blatantly walk out of the front " +
                    "entrance, exactly like how Agent 47 does it! \n\nPress " +
                    "P to Play again. \nBut why? Honest warning: this game " +
                    "as one-dimensional as it can get!";
        if (Input.GetKeyDown(KeyCode.P))
            myState = States.Cell;
    }
}
