#include <LiquidCrystal.h>
#include <SPI.h>
#include <MFRC522.h>

#define SS_PIN 10
#define RST_PIN 9
MFRC522 mfrc522(SS_PIN, RST_PIN);   // Create MFRC522 instance.

LiquidCrystal lcd(5,4,3,2,1,0);

void setup() {
  // put your setup code here, to run once:
lcd.begin(16,2);
pinMode(7, OUTPUT);
pinMode(6, OUTPUT);

  SPI.begin();      // Initiate  SPI bus
  mfrc522.PCD_Init();   // Initiate MFRC522
  lcd.print("Use reader");
}

void(* resetFunc) (void) = 0;//declare reset function at address 0

void loop() {
  // put your main code here, to run repeatedly:
lcd.setCursor(0,1);

// Look for new cards
  if ( ! mfrc522.PICC_IsNewCardPresent()) 
  {
    return;
  }
  // Select one of the cards
  if ( ! mfrc522.PICC_ReadCardSerial()) 
  {
    return;
  }
  //Show UID on serial monitor
  Serial.print("UID tag :");
  String content= "";
  byte letter;
  for (byte i = 0; i < mfrc522.uid.size; i++) 
  {
     content.concat(String(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " "));
     content.concat(String(mfrc522.uid.uidByte[i], HEX));
  }
  content.toUpperCase();
  if (content.substring(1) == "EB 53 91 89") //change here the UID of the card/cards that you want to give access
  {
    
    lcd.print("Authorized access");
    tone( 8, 5000, 250);
    digitalWrite(7, HIGH);  
    delay(1000);
    digitalWrite(7, LOW);
    tone( 8, 5000, 250);
    delay(3000);
    resetFunc();
  }
 
 else   {
  
    lcd.print("Access denied");
    tone(8, 1000, 500);
    digitalWrite(6, HIGH);
    delay(1000);
    digitalWrite(6, LOW);
    delay(2000);
    resetFunc();
  }
}
