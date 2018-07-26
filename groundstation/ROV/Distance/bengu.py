import win32api
import win32con
import time
import math
import easygui

constValues = []

shiftButton = win32con.VK_SHIFT
leftButton = win32con.VK_RIGHT
rightButton = win32con.VK_LEFT
downButton = win32con.VK_DOWN
controlButton = win32con.VK_CONTROL
esc = win32con.VK_ESCAPE

def findFocal(length):
    if (length < 10):
        focal = 580
    elif (length > 10 and length < 20):
        focal = 630
    elif (length > 20 and length < 30):
        focal = 680
    else:
        focal = 730
    return focal

def MouseBaslangic():
    mousePosition = win32api.GetCursorPos()
    return mousePosition

def MouseSon():
    mousePosition = win32api.GetCursorPos()
    return mousePosition

def MouseTiklama():
    while True:
        if(win32api.GetAsyncKeyState(leftButton)):
            startPos = MouseBaslangic()
            print("Start Point : ", startPos)
            time.sleep(0.2)

        if(win32api.GetAsyncKeyState(rightButton)):
            endPos = MouseSon()
            print("Stop Point : ", endPos)
            time.sleep(0.2)

        if(win32api.GetAsyncKeyState(downButton)):
            distanceSquare = (startPos[0] - endPos[0])**2 + (startPos[1] - endPos[1])**2
            distance = math.sqrt(distanceSquare)
            time.sleep(0.2)
            return distance

while(1):
    if(win32api.GetAsyncKeyState(shiftButton)):
        cm = float(easygui.enterbox(msg='Enter known length: '))
        focalConstant = findFocal(cm)
        startVerticalp = MouseTiklama()
        foundStartDistance = (focalConstant * cm) / startVerticalp
        cm = float(easygui.enterbox(msg='Enter known length: '))
        stopVerticalp = MouseTiklama()
        foundStopDistance = (focalConstant * cm) / stopVerticalp
        foundVerticalDistance = math.sqrt(foundStartDistance**2 - foundStopDistance**2)
        easygui.msgbox(foundVerticalDistance, title="Result:")
        file = open("resultVertical.txt","a") # Copy of Master ENES
        file.write("\n" + str(foundVerticalDistance))
        file.close()
    if(win32api.GetAsyncKeyState(controlButton)):
        cm = float(easygui.enterbox(msg='Enter known length: '))
        focalConstant = findFocal(cm)
        pixelLength = MouseTiklama()
        foundDistance = (focalConstant * cm) / pixelLength
        easygui.msgbox(foundDistance, title="Result:")
        file = open("result.txt", "a") # Don't fuc*ing delete this line
        file.write("\n" + str(foundDistance)) # Don't fuc*ing delete this line
        file.close() # Don't fuc*ing delete this line
    if (win32api.GetAsyncKeyState(esc)):
        break
