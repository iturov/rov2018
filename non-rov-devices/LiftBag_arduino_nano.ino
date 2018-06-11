float wait = 1.6;
float voltInput = 0;
int eStep = 3;
int dir = 2;
int start = 4;
int i = 0;
int donme = 0;
void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  pinMode(eStep,OUTPUT);
  pinMode(dir, OUTPUT);
  pinMode(start, OUTPUT);
  delay(1000);
}

void loop() {
  // put your main code here, to run repeatedly:
  voltInput = analogRead(A6);
  voltInput = 5 * (voltInput / 1024);
  Serial.println(voltInput);
  while(voltInput > 2.0){
    voltInput = analogRead(A6);
    voltInput = 5 * (voltInput / 1024);
    Serial.println("While:" + String(voltInput));
    if (donme == 0){
      Turn();
      }
    donme = 1;
    }
  Serial.println("whiledan çıktı");
  if (donme == 1){
    inverseTurn();
    }
    donme = 0;
}

void Turn(){
  //Serial.println("normal dön");
  digitalWrite(start, HIGH);
  digitalWrite(dir, HIGH);
  for(i = 0;i<100;i++){
    digitalWrite(eStep,HIGH);
    delay(wait);
    digitalWrite(eStep, LOW);
    delay(wait);
    }
  digitalWrite(start,LOW);
}

void inverseTurn(){
  //Serial.println("ters dön");
  digitalWrite(start, HIGH);
  digitalWrite(dir, LOW);
  for(i = 0;i<100;i++){
    digitalWrite(eStep,HIGH);
    delay(wait);
    digitalWrite(eStep, LOW);
    delay(wait);
    }
  digitalWrite(start,LOW);
}
