int contador = 0;
void setup() {
  Serial.begin(115200);
  pinMode(2, OUTPUT);
}

void loop() {
  Serial.println("Hola-" + String(contador++));
  digitalWrite(2, !digitalRead(2));
  delay(500);
}
