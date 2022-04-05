void initGPIO()
{
  pinMode(ONBOARD_LED, OUTPUT);
  digitalWrite(ONBOARD_LED, LOW);
  
  pinMode(PIN_LED, OUTPUT);
  digitalWrite(PIN_LED, LOW);
  
  pinMode(ANALOG_PIN, INPUT);
}

void turnOnDigitalPin(int digitalPin){
  digitalWrite(digitalPin, HIGH);
}

void turnOffDigitalPin(int digitalPin){
  digitalWrite(digitalPin, LOW);
}

int readAnalogPin()
{
  return analogRead(ANALOG_PIN);  
}

int readDigitalPin(int digitaPin)
{
  return digitalRead(digitaPin);  
}
