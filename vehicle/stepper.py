from time import sleep
import RPi.GPIO as GPIO

DIR = 20   # Direction GPIO Pin
STEP = 21  # Step GPIO Pin
CW = 1     # Clockwise Rotation
CCW = 0    # Counterclockwise Rotation
SPR = 2000   # Steps per Revolution (360 / 1.8)

GPIO.setmode(GPIO.BCM)
GPIO.setup(DIR, GPIO.OUT)
GPIO.setup(STEP, GPIO.OUT)
GPIO.output(DIR, CW)
GPIO.setup(4,GPIO.OUT)
step_count = SPR
delay = .0008

GPIO.output(4,GPIO.HIGH) # Power ON

for x in range(step_count):
    GPIO.output(STEP, GPIO.HIGH)
    sleep(delay)
    GPIO.output(STEP, GPIO.LOW)
    sleep(delay)
    
GPIO.output(4,GPIO.LOW) # Power OFF

sleep(1.5)

GPIO.output(4,GPIO.HIGH) # Power ON
GPIO.output(DIR, CCW) # Change direction

for x in range(step_count):
    GPIO.output(STEP, GPIO.HIGH)
    sleep(delay)
    GPIO.output(STEP, GPIO.LOW)
    sleep(delay)
    
GPIO.output(4,GPIO.LOW) # Power OFF

GPIO.cleanup()
