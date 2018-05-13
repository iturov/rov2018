#include <ESP8266WiFi.h>
#include <WiFiClient.h>
#include <ESP8266WebServer.h>

long randNumber = 0;
const char *ssid = "LiftBag2Net";
const char *password = "password";

const char INDEX_HTML[] =
"<!DOCTYPE HTML>
<html>
<head>
<meta name = \"viewport\" content = \"width = device-width, initial-scale = 1.0, maximum-scale = 1.0, user-scalable=0\">
<title>Rovians GO</title>
<style>
\"body { background-color: #808080; font-family: Arial, Helvetica, Sans-Serif; Color: #000000; }\"
</style>
</head>
<body>
<h1>Lift Bag Missions</h1>
<FORM action=\"/\" method=\"post\">
<P>
Selenoid<br>
<INPUT type=\"button\" name=\"butonAC\" value=\"Open Selenoid\" onclick=\"window.location.href='/ac'\"><BR>
<INPUT type=\"button\" name=\"butonAC\" value=\"Close Selenoid\"onclick=\"window.location.href='/kapa'\"><BR>
<h3>"+String(randNumber)+"</h3>
</P>
</FORM>
</body>
</html>"
;


ESP8266WebServer server(80);

void handleRoot() {
server.send(200, "text/html", INDEX_HTML);
}

void setup() {
pinMode(13,OUTPUT);
delay(1000);
Serial.begin(115200);

Serial.println();

Serial.print("Configuring access point...");

WiFi.softAP(ssid, password);

IPAddress myIP = WiFi.softAPIP();

Serial.print("AP IP address: ");

Serial.println(myIP);

server.on("/", handleRoot);
server.on("/ac", selenyak);
server.on("/kapa", selenson);


server.begin();

Serial.println("HTTP server started");

randomSeed(analogRead(13));
}

void loop() {
randNumber = random(300);
delay(75); 
server.handleClient();
}

void selenyak(){
  digitalWrite(13,HIGH);
  server.send(200, "text/html", INDEX_HTML);
  }


void selenson(){
    digitalWrite(13,LOW);
  server.send(200, "text/html", INDEX_HTML);
  }
