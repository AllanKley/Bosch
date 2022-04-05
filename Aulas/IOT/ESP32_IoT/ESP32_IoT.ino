#include <DHT.h>
#include <PubSubClient.h>
#include <WiFi.h>


#define PIN_LED 2
#define DHTPIN 4
#define DHTTYPE DHT11
#define ANALOG_PIN 15
#define ONBOARD_LED 16

WiFiClient espClient; 
PubSubClient MQTT(espClient); 
DHT dht(DHTPIN, DHTTYPE);

void setup() {
  // put your setup code here, to run once:
  
initSerial();
initWiFi();
initMQTT();

dht.begin();  

pinMode(PIN_LED, OUTPUT);
pinMode(ANALOG_PIN, INPUT);

}

void loop() {
  // code here
    
    digitalWrite(2, HIGH);

    if (MQTT.connected()){
      float h = getHumidity();
      float t = getTemperature();
      float l = readLDRSensor();

      if(isnan(h) || isnan(t)){
        Serial.println(F("Failed to read from DHT Sensor!"));
        delay(1000);
        return;
      }
      
      if(isnan(l)){
        Serial.println(F("Failed to read from LDR Sensor!"));
        return;
      }

      char payload[255];
      sprintf(payload,"{\"humid\":\"%.2f\",\"temp\":\"%.2f\"}",h, t);
      MQTTPublish(payload);
      
      MQTT.loop();    
    }
  else {
    digitalWrite(2,LOW);
    VerificaConexoesWiFIEMQTT();
  }

  delay(5000);
}
