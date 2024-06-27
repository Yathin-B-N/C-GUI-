
String data;
char d1;
int ledval;
String x;
unsigned long debouncingdelay = 5;
unsigned long lastdebouncingTime=0;
int buttonstate;
int lastbuttonstate = HIGH;
int value=0;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(13,OUTPUT);
  pinMode(3,OUTPUT);
  pinMode(5,OUTPUT);
  pinMode(6,OUTPUT);
  pinMode(9,INPUT_PULLUP);
 

}

void loop() {
  // put your main code here, to run repeatedly:
if(Serial.available())
{
  data = Serial.readString();
  d1 = data.charAt(0);
  switch(d1)
  {
    case 'A':
     digitalWrite(13,HIGH);
     break;
     case 'a':
     digitalWrite(13,LOW);
     break;
     case 'R':
     x = data.substring(1);
     ledval = x.toInt();
     analogWrite(3,ledval);
     break;
     case 'G':
     x = data.substring(1);
     ledval = x.toInt();
     analogWrite(5,ledval);
     break;
     case 'Y':
     x = data.substring(1);
     ledval = x.toInt();
     analogWrite(6,ledval);
     break;

  } 
}
// Handledbutton();   
value = analogRead(9);
Serial.println(value);

}


//  void Handledbutton(void)
//  {
//   int reading = digitalRead(9); 
//    if(reading != lastbuttonstate)
//    {
//     lastdebouncingTime = millis();
//    }

//    if((millis()-lastdebouncingTime) > debouncingdelay)
//    {
//       if(reading != buttonstate)
//       {
//         buttonstate = reading;
//         if(buttonstate == HIGH)
//         {
//           Serial.println("p");
//         }
//       }
//    }
// lastbuttonstate = reading;

//  }

