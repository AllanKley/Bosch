//---------------------------------------------------------------------------------------------------------------

// BIBLIOTECAS
#include <DHT.h>
#include <WiFi.h>
#include <FirebaseESP32.h>
#include <LiquidCrystal.h>


// WIFI
#define WIFI_SSID "Vivo-Internet-BF17"
#define WIFI_PASSWORD "78814222"


// FIREBASE
#define FIREBASE_HOST "https://dht-allan-default-rtdb.firebaseio.com/"
#define FIREBASE_AUTH "An5vDHmJpsG5H8Id9CchorIbrJQcrpK5M8tQg4Lz"
FirebaseData firebaseData;
FirebaseJson json;


// LCD
LiquidCrystal lcd(19, 23, 18, 17, 16, 15);


// DHT
#define DHTPIN 4     
#define DHTTYPE DHT11  
DHT dht(DHTPIN, DHTTYPE);


// VARIAVEIS
int timer=0;
float temperatura=0;
float umidade=0;
int botao = 12;

//---------------------------------------------------------------------------------------------------------------

void setup() {

  // INICIANDO SERIAL 
  Serial.begin(9600);

  pinMode(botao, INPUT_PULLUP);
  
  // INICIANDO LCD 
  lcd.begin(16, 2);

  // INICIANDO LEDS 
  pinMode(21, OUTPUT);
  pinMode(03, OUTPUT);
  pinMode(13, OUTPUT);
  pinMode(22, OUTPUT);

  
  // INICIANDO DHT 
  dht.begin();
  
  
   
  // INICIANDO CONEXAO FIREBASE 
  Firebase.begin(FIREBASE_HOST, FIREBASE_AUTH);
  Firebase.reconnectWiFi(true);
  Firebase.setReadTimeout(firebaseData, 1000*60);
  Firebase.setwriteSizeLimit(firebaseData, "tiny"); 

   
  // CONECTANDO A WIFI 
WiFi.begin(WIFI_SSID,WIFI_PASSWORD);
  
  while(WiFi.status() != WL_CONNECTED){
    Serial.print(".");
    delay(300);
  }
  Serial.print("\nConnected with IP: ");
  Serial.println(WiFi.localIP());
  
  
}


//---------------------------------------------------------------------------------------------------------------

void loop() {

  /*
  // TESTE
  digitalWrite(21, HIGH);
  digitalWrite(03, HIGH);
  digitalWrite(13, HIGH);
  digitalWrite(22, HIGH);
  delay(1000);
  digitalWrite(21, LOW);
  digitalWrite(03, LOW);
  digitalWrite(13, LOW);
  digitalWrite(22, LOW);
  */
  
  // LEITURA DE DADOS 
  temperatura=dht.readTemperature();
  umidade=dht.readHumidity();
  

  // IMPRIMIR DADOS LIDOS
  lcd.print("Temp: ");
  lcd.print(temperatura);
  lcd.print("      ");
  lcd.setCursor(0,2);
  lcd.print("Umidade: ");
  lcd.print(umidade);
  lcd.print("      ");


  // LEDS DE TEMPERATURA 
  if(temperatura<=25){
    digitalWrite(21, HIGH);
    digitalWrite(03, LOW);
    digitalWrite(01, LOW);
  }else if(temperatura<27){
    digitalWrite(21, LOW);
    digitalWrite(03, HIGH);
    digitalWrite(01, LOW);
  }else{
    digitalWrite(21, LOW);
    digitalWrite(03, LOW);
    digitalWrite(01, HIGH);
  }
   
  // ENVIO DE DADOS AO FIREBASE 
  if((timer%30==0) && (digitalRead(botao) != LOW)){

    Serial.print("Enviando");
    Serial.print("");
  
    json.set("/Temperatura",temperatura);
    json.set("/Umidade", umidade);
    
    digitalWrite(22, HIGH);
    Firebase.updateNode(firebaseData, "/Sensor", json);
    Serial.print("enviado");
    Serial.print("");
  }
  digitalWrite(22, LOW);

  timer++;

  delay(1000);
}


//---------------------------------------------------------------------------------------------------------------
