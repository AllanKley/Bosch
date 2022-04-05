// REQUIRES the following Arduino libraries:
// - DHT Sensor Library: https://github.com/adafruit/DHT-sensor-library
// - Adafruit Unified Sensor Lib: https://github.com/adafruit/Adafruit_Sensor

// Reading temperature or humidity takes about 250 milliseconds!
// Sensor readings may also be up to 2 seconds 'old' (its a very slow sensor)
 
float getTemperature(void)
{
    float t = dht.readTemperature();
    return t;
}

float getHumidity(void)
{
    float h = dht.readHumidity(); 
    return h;
}
