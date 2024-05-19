#include <BluetoothSerial.h>

#include <ESP32Servo.h>;

BluetoothSerial SerialBT;

Servo s;
Servo s1;
int data = 0;
int data1 = 0;
int value,value1;
void setup() {
  SerialBT.begin("hello");
  Serial.begin(115200);
  s.attach(13);
  s1.attach(12);

}

void loop() {
  if (SerialBT.available() > 0)
  {
    data = SerialBT.read();
    if (data > 0)
    {
      value = data;
    }
    s.write(value);
    
    data1 = SerialBT.read();
    if (data1 > 0)
    {
      value1 = data1;
    }
    s1.write(value1);

  }
  delay(20);
}
