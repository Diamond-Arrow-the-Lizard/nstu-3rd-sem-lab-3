using System;
namespace Entity;

public class Entity  {
    
    public string Name {set; get; } = "Entity";

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
    public int BaseATK {
        set {
            if(value <= 0) {
                throw new Exception("ERROR: invalid ATK value.");
            }
            else {
                _atk = value;
            }
        } 
        get => _atk;
    }

    private int _def = 0;
    public int BaseDEF {
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

    public bool isAlive {set; get; } = true;


}
