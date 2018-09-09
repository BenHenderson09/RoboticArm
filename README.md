# RoboticArm with GUI
I created a fully functional robotic arm with a custom GUI. The code for the movement of the arm is written in C++, as this is the
language used by the Arduino Uno microcontroller board. The GUI is uses serial communication and is coded in C# using Windows Forms.

## Parts
 - 5 metal gear servo motors
 - A cheap frame
 - An external power source
 - An Arduino
 - Some jumper wires

## Movement
The robotic arm has 5 servos attached for movement, each offering 180 degrees of rotation. The movement points are as follows:
- Base X-axis
- Base Y-axis
- Top  Y-axis
- Top  X-axis
- Claw grab

The claw grab uses gears to transform the movement of the servo to the closing and opening of a "claw".

## The GUI
![](https://github.com/BenHenderson09/RoboticArm/blob/master/GUI.png)

The GUI uses serial communication to interact with the arduino over a wired connection. Each time a button is pressed or released,
a signal will be sent to the Arduino to move the corresponding servos. In the top right of the GUI you may have noticed a 
`Numerical up-down` feature. This is to select the serial communications port. By default it is set to `COM8`, this is how my arduino is
configured.
