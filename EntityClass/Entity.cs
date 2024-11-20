using System;
namespace Entity;

public class Entity {
    
    // TODO Active and Passive skills
    
    public string Name {set; get; } = "Entity";
    public bool isAlive {set; get; } = true;

    private int _hp = 1;
    public int HP {
        set {
            if(value < 0) {
                throw new Exception("ERROR: invalid HP value.");
            }
            else {
                _hp = value;
            }
        } 
        get => _hp;
    }
    
    private int _atk = 1;
    public int ATK {
        set {
            if(value < 0) {
                throw new Exception("ERROR: invalid ATK value.");
            }
            else {
                _atk = value;
            }
        } 
        get => _atk;
    }

    private int _def = 0;
    public int DEF {
        set {
            if(value < 0) {
                throw new Exception("ERROR: invalid DEF value.");
            }
            else {
                _def = value;
            }
        } 
        get => _def;
    }


    // TODO: Destroying Entity if it's dead
    public void checkIfAlive() {
        if(isAlive == false) {
        }

        if(HP == 0) {
            isAlive = false;
        } 
    }
    
    // TODO
    public void takeDamage(int takenDamage) {

    }

}
