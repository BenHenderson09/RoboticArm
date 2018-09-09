#include <Servo.h>

Servo baseX;
int baseXPin = 12;

Servo baseY;
int baseYPin = 11;

Servo topY;
int topYPin = 10;

Servo topX;
int topXPin = 9;

Servo grab;
int grabPin = 8;


void setup() {
  Serial.begin(9600);
  Serial.setTimeout(50);

  
  // Set each servo to start position 
  baseX.attach(baseXPin);
  baseX.write(100);

  baseY.attach(baseYPin);
  baseY.write(60);

  topY.attach(topYPin);
  topY.write(50);

  topX.attach(topXPin);
  topX.write(50);

  grab.attach(grabPin);
  grab.write(180);

}

String data;
void loop() {
  if (Serial.available()){
    data = Serial.readString();

    // Base controls
    // Base Up
    if (data == "bu") { 
     while (data != "s") {
        data = Serial.readString(); baseY.write(baseY.read() + 2); delay(1);
      }
    }
    
    // Base Down
    if (data == "bd") { 
      while (data != "s") {
        data = Serial.readString(); baseY.write(baseY.read() - 2); delay(1);
      }
    }

    // Base Left
    if (data == "bl") { 
      while (data != "s") {
        data = Serial.readString(); baseX.write(baseX.read() + 6); delay(1);
      }  
    }

    // Base Right
    if (data == "br") { 
      while (data != "s") {
        data = Serial.readString(); baseX.write(baseX.read() - 6); delay(1);
      }  
    }

    // Top controls
    // Top Up
    if (data == "tu") { 
      while (data != "s") {
        data = Serial.readString(); topY.write(topY.read() + 2); delay(1);
      }  
    }

    // Top Down
    if (data == "td") { 
      while (data != "s") {
        data = Serial.readString(); topY.write(topY.read() - 2); delay(1);
      }   
    }

    // Claw controls
    // Claw Left
    if (data == "cl") { 
      while (data != "s") {
        data = Serial.readString(); topX.write(topX.read() + 3); delay(1);
      }    
    }

    // Claw Right
    if (data == "cr") { 
      while (data != "s") {
        data = Serial.readString(); topX.write(topX.read() - 3); delay(1);
      }    
    }
    
    // Close Claw
    if (data == "cc") {
      while (data != "s") {
        data = Serial.readString(); grab.write(grab.read() + 5); delay(1);
      }   
    }

    // Open Claw
    if (data == "co") {
      while (data != "s") {
        data = Serial.readString(); grab.write(grab.read() - 5); delay(1);
      }   
    }
  }
}


