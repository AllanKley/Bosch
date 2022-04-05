float readLDRSensor(){
  int ldrValue = map(analogRead(ANALOG_PIN),0,1023,0,100);
  return ldrValue;
}
