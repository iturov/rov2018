import win32api
import win32con
import time
import math
import cv2
import easygui

leftButton = win32con.VK_LBUTTON
rightButton = win32con.VK_MBUTTON
downButton = win32con.VK_DOWN
knownLength = 13
focalLength = 1472.307

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
            print("Başlangıç : ", startPos)
            time.sleep(0.2)

        if(win32api.GetAsyncKeyState(rightButton)):
            endPos = MouseSon()
            print("Bitiş : ", endPos)
            time.sleep(0.2)

        if(win32api.GetAsyncKeyState(downButton)):
            distanceSquare = (startPos[0] - endPos[0])**2 + (startPos[1] - endPos[1])**2
            distance = math.sqrt(distanceSquare)
            time.sleep(0.2)
            sonuc = (focalLength * knownLength) / distance
            easygui.msgbox(sonuc, title="Sonuç:")
            break

#   Uzaklik = (focalLength * knownLength) / pixelWidth
#   print(Uzaklik)

c = cv2.VideoCapture(0)

while(1):
    _,f = c.read()
    cv2.imshow('e2',f)
    if cv2.waitKey(5)== ord('a'):
        break
    if (win32api.GetAsyncKeyState(win32con.VK_CONTROL)):
        MouseTiklama()
cv2.destroyAllWindows()
