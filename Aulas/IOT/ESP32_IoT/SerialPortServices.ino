#define BAUD_RATE 9600

void initSerial()
{
    Serial.begin(BAUD_RATE);
    Serial.setDebugOutput(false);
    //Wait for port to be open
    while (!Serial) {
    }
    Serial.println();
    Serial.println("Connected to serial port on baud rate 9600");
}
