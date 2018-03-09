import win32api
import win32con
import time
import math
import easygui


leftButton = win32con.VK_LBUTTON
rightButton = win32con.VK_MBUTTON
downButton = win32con.VK_DOWN
controlButton = win32con.VK_CONTROL
esc = win32con.VK_ESCAPE

def degerleriCek():
    satirlar = open('degerler.txt', 'r')
    geciciListe = []
    for satir in satirlar:
        geciciListe.append(satir)
    knownLength = float(geciciListe[0])
    focalLength = float(geciciListe[1])
    return knownLength, focalLength

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
            return distance

def katSayiHesapla():
    knownLength = int(easygui.enterbox(msg = 'Enter known length: '))
    knownDistance = int(easygui.enterbox(msg = 'Enter known distance: '))
    pixelLength = MouseTiklama()
    hesaplananKatsayi = knownDistance * pixelLength / knownLength
    degerler = [str(knownLength), '\n', str(hesaplananKatsayi)]
    dosya = open('degerler.txt','w')
    dosya.writelines(degerler)
    dosya.close()


while(1):
    if(win32api.GetAsyncKeyState(controlButton)):
        knownLength, focalLength = degerleriCek()
        pixelLength = MouseTiklama()
        foundDistance = (focalLength * knownLength) / pixelLength
        easygui.msgbox(foundDistance, title="Sonuç:")
    if (win32api.GetAsyncKeyState(esc)):
        break
    if(win32api.GetAsyncKeyState(0x58)):
        katSayiHesapla()
