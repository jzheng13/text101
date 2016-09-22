using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States {Cell, Cell_Mirror, Freedom, Lock_0, Lock_1, Mirror,
        Sheet_0, Sheet_1, Closet_Door, Floor, Stairs_0 };
    private States myState;

    void Start() {
        myState = States.Cell;
    }
    
    void Update() {
        switch(myState) {
            case States.Cell: state_cell(); break;
            case States.Cell_Mirror: state_cellMirror(); break;
            case States.Freedom: state_freedom(); break;
            case States.Lock_0: state_lock0(); break;
            case States.Lock_1: state_lock1(); break;
            case States.Mirror: state_mirror(); break;
            case States.Sheet_0: state_sheet0(); break;
            case States.Sheet_1: state_sheet1(); break;
            case States.Closet_Door; state_closetDoor(); break;
            case States.Floor; state_floor(); break;
            case States.Stairs_0; state_stairs0(); break;
            default: break;
        }
    }

    void state_cell() {
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

    void state_sheet0() {
        text.text = "You can't believe you've been living in this shithole" +
                    " for nearly 18 months! Those sheets are disgusting!\n\n" +
                    "Press R to Return to roaming your cell.";
        if (Input.GetKeyDown(KeyCode.R))
            myState = States.Cell;

    }

    void state_mirror() {
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

    void state_lock0()  {
        text.text = "It's one of those pin locks. You crane your neck trying" +
                    " to make out something. Nope, nothing. 0000? Don't be " +
                    "daft. This game is easy, but not that easy. \n\n Press " +
                    "R to Return to roaming your cell.";
        if (Input.GetKeyDown(KeyCode.R))
            myState = States.Cell;
    }

    void state_cellMirror() {
        text.text = "You hold the mirror in your hands, not quite sure what " +
                    "to do with it. There's a light patch on the wall where " +
                    "the mirror used to hang, probably the only clean spot " +
                    "in the whole cell. You are still stuck in this hell of " +
                    "a place, there are still dirty sheets on your bed, and " +
                    "the prison door is still shut. \n\nPress S to view " +
                    "Sheets, L to look at the Lock.";
        if (Input.GetKeyDown(KeyCode.S)) {
            myState = States.Sheet_1;
        } else if (Input.GetKeyDown(KeyCode.L)) {
            myState = States.Lock_1;
        }
    }

    void state_sheet1() {
        text.text = "You are half-tempted to wipe the mirror with your " +
                    "sheets, but you thought better. Those sheets can't " +
                    "clean anything. \n\n Press R to Return to roaming " +
                    "your cell.";
        if (Input.GetKeyDown(KeyCode.R))
            myState = States.Cell_Mirror;
    }

    void state_lock1() {
        text.text = "You hold the mirror out to look at the lock properly, " +
                    "but it drops to the ground! Not before you see the " + 
                    "fingerprints on the combination though. Yucks, those " +
                    "prison guards have got some dirty fingers...\n\n Press" +
                    " R to Return to your cell and give up on freedom, " +
                    "press E to Escape.";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.Cell_Mirror;
        } else if (Input.GetKeyDown(KeyCode.E)) {
            myState = States.Freedom;
        }
    }

    void state_freedom() {
        text.text = "You look at your fingers, slightly repulsed. But all's " +
                    "good now that you are out. You look around cautiously, " +
                    "but there's no one. A creepy stairwell is to the left, " +
                    "and there's a cleaning closet on the right. \n\n Press " +
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

    void state_closetDoor() {

    }

    void state_floor() {

    }

    void state_stairs0() {

    }
}
