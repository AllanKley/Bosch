#define TOPICO_PUBLISH   "Treinamento/ets/allankley"   
#define ID_MQTT  "cliente_allankley" 

const char* BROKER_MQTT = "broker.hivemq.com"; 
int BROKER_PORT = 1883; 

void initMQTT() 
{
    MQTT.setServer(BROKER_MQTT, BROKER_PORT);
}
 
void reconnectMQTT() 
{
    while (!MQTT.connected()) 
    {
        Serial.print("* Tentando se conectar ao Broker MQTT: ");
        Serial.println(BROKER_MQTT);
        if (MQTT.connect(ID_MQTT)) 
        {
            Serial.println("Conectado com sucesso ao broker MQTT!");
        } 
        else
        {
            Serial.println("Falha ao reconectar no broker.");
            Serial.println("Havera nova tentatica de conexao em 2s");
            delay(2000);
        }
    }
}
 
void VerificaConexoesWiFIEMQTT(void)
{
    if (!MQTT.connected()) 
        reconnectMQTT();
     
     reconectWiFi();
}
 
void MQTTPublish(const char payload[280])
{
    MQTT.publish(TOPICO_PUBLISH, payload);
 
    Serial.println("Mensagem enviada por MQTT: ");
    Serial.println(payload);
    delay(500);
}
