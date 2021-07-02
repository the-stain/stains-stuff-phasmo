# stains-stuff-phasmo
Remake #2: Phasmophobia

The second project in my remake series (where I recreate mechanics/puzzles/etc. from video games). My goal here is to recreate the Thermometer from Phasmophobia.

### **Currently WIP**

This project differs quite a bit from my first one (the Weather Node puzzle from Among Us) in that I'm putting much more effort into properly structuring the code. 
In this case, I figured I could afford to do so since I'm more familiar with the techniques I'm using.

The plan right now is to make liberal use of Unity's Entity-Component System and Scriptable Objects to build a thermometer prefab and design a rudimentary imitation 
of the game's temperature system. My biggest struggle is just maintaining my scope since, in the process of designing components, I try to do so in a way that would 
work in the game itself. Naturally, this leads to considering how other tools would use that component, how it would need to compensate for other systems in the 
game -- then it's all downhill from there. :sweat_smile:
