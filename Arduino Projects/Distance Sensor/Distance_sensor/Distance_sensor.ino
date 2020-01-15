/*   Blink   Turns on an LED on for one second, then off for one second, repeatedly.     This example code is in the public domain.  */   
// Pin 13 has an LED connected on most Arduino boards.
// give it a name: 
int led5 = 12; 
int led4 = 11; 
int led3 = 10; 
int led2 = 9; 
int led1 = 8; 
const int MaxLED = 5;
int CurrentLed =  1;

const int trigPin = 7;
const int echoPin = 6;
// defines variables
long duration;
int distance;
 
// the setup routine runs once when you press reset:
void setup() {             
  // initialize the digital pin as an output.  
  pinMode(led1, OUTPUT);    
  pinMode(led2, OUTPUT); 
  pinMode(led3, OUTPUT); 
  pinMode(led4, OUTPUT); 
  pinMode(led5, OUTPUT); 

  pinMode(trigPin, OUTPUT); // Sets the trigPin as an Output
  pinMode(echoPin, INPUT); // Sets the echoPin as an Input
  Serial.begin(9600); // Starts the serial communication
  } 

 
// the loop routine runs over and over again forever:
void loop() {  
  if (CurrentLed > MaxLED || CurrentLed < 1)
  {
    CurrentLed = 1;
  }
  CurrentLed = DeterminePos();
  CurrentLed++;
  Alternate(CurrentLed);
  //CurrentLed++;
  delay(500);  
  LEDsOFF();
}

int DeterminePos()
{
  int resulte = 0;
  // Clears the trigPin
  digitalWrite(trigPin, LOW);
  delayMicroseconds(2);
  // Sets the trigPin on HIGH state for 10 micro seconds
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);
  // Reads the echoPin, returns the sound wave travel time in microseconds
  duration = pulseIn(echoPin, HIGH);
  // Calculating the distance
  distance= duration*0.034/2;
  // Prints the distance on the Serial Monitor
  Serial.print("Distance: ");
  Serial.println(distance);
  if (distance < 100)
  {
    if (distance < 50)
    {
      if (distance <20)
      {
        if (distance <10)
        {
          resulte = 5;
        }
        else
        {resulte = 4;} 
      }
      else
      {resulte = 3;}    
      }
      
    else
    {resulte = 2;}
  }
  else
  {resulte = 1;}
  
  return resulte;
  }

void FirstLED()
{
  digitalWrite(led1, HIGH);   // turn the LED on (HIGH is the voltage level)  
  delay(100);               // wait for a second  
  //digitalWrite(led1, LOW);    // turn the LED off by making the voltage LOW   
  //delay(100);               // wait for a second 
}

void SecondLED()
{
  digitalWrite(led2, HIGH);   // turn the LED on (HIGH is the voltage level)  
  delay(100);               // wait for a second  
  //digitalWrite(led2, LOW);    // turn the LED off by making the voltage LOW   
  //delay(100);               // wait for a second 
}

void ThirdLED()
{
  digitalWrite(led3, HIGH);   // turn the LED on (HIGH is the voltage level)  
  delay(100);               // wait for a second  
  //digitalWrite(led3, LOW);    // turn the LED off by making the voltage LOW   
  //delay(100);               // wait for a second 
}

void FourthLED()
{
  digitalWrite(led4, HIGH);   // turn the LED on (HIGH is the voltage level)  
  delay(100);               // wait for a second  
  //digitalWrite(led4, LOW);    // turn the LED off by making the voltage LOW   
  //delay(100);               // wait for a second 
}

void FithLED()
{
  digitalWrite(led5, HIGH);   // turn the LED on (HIGH is the voltage level)  
  delay(100);               // wait for a second  
  //digitalWrite(led5, LOW);    // turn the LED off by making the voltage LOW   
  //delay(100);               // wait for a second 
}

void LEDsOFF()
{
   digitalWrite(led1, LOW);    // turn the LED off by making the voltage LOW   
    digitalWrite(led2, LOW);    // turn the LED off by making the voltage LOW   
     digitalWrite(led3, LOW);    // turn the LED off by making the voltage LOW   
      digitalWrite(led4, LOW);    // turn the LED off by making the voltage LOW   
       digitalWrite(led5, LOW);    // turn the LED off by making the voltage LOW   
  }



void Alternate(int ledNo)
{
  for (int i = 0; i < ledNo;i++)
  {switch(i)
  {
    case 1:
      FirstLED();
      break;

     case 2:
      SecondLED();
      break;

    case 3:
      ThirdLED();
      break;

    case 4:
      FourthLED();
      break;

    case 5:
      FithLED();
      break;     
      
   default:
      digitalWrite(led1, HIGH);   // turn the LED on (HIGH is the voltage level)  
      delay(100);               // wait for a second  
      digitalWrite(led1, LOW);    // turn the LED off by making the voltage LOW   
      delay(100);               // wait for a second 
      break;
    }
  }
  }
