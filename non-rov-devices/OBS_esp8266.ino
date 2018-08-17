#include <ESP8266WiFi.h>
#include <WiFiClient.h> 
#include <ESP8266WebServer.h>
String data = "";
String tempData = "";
/* Set these to your desired credentials. */
const char *ssid = "ESPap";
const char *password = "123456789";

ESP8266WebServer server(80);
 

void handleRoot() {
  String INDEX_HTML =
"<!DOCTYPE HTML>"
"<html>"
"<head>"
"<meta name = \"viewport\" content = \"width = device-width, initial-scale = 1.0, maximum-scale = 1.0, user-scalable=0\">"
"<title>OBS PROP</title>"
"<style>"
"\"body { background-color: #808080; font-family: Arial, Helvetica, Sans-Serif; Color: #000000; }\""
"</style>"
"</head>"
"<body>"
"<h1>MATE ROV 2018 OBS</h1>"
"<P><h3>"
+data+
"</h3>"
"</P>"
"</FORM>"
"</body>"
"</html>"
; 
  server.send(200, "text/html", INDEX_HTML);
  delay(500);
}

void setup() {
	delay(1000);
	Serial.begin(115200);
	Serial.println();
	Serial.print("Configuring access point...");
	/* You can remove the password parameter if you want the AP to be open. */
	WiFi.softAP(ssid, password);

	IPAddress myIP = WiFi.softAPIP();
	Serial.print("AP IP address:   ");
	Serial.println(myIP);
	server.on("/", handleRoot);
	server.begin();
	Serial.println("HTTP server started");
}

void loop() {

while(Serial.available())
{
  Serial.println("available girdi");
  char c = Serial.read(); // read the next character.
  tempData+=c;
}
if (tempData != ""){
  data = tempData;
}
  tempData = "";  
  delay(1);
	server.handleClient();
}
