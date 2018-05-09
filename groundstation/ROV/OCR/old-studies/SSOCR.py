import pyscreenshot as ImageGrab
import cv2
import numpy as np
import pytesseract
from PIL import Image
import time

src_path ="C:\\Users\\Public\\ROV\\OCR\\old\\"

while True :

    image =cv2.imread(src_path+"init.png")



    text=[]
    a = pytesseract.image_to_string(Image.open(src_path +'init.png'))
    text.append(a)
    img = cv2.imread(src_path + 'init.png')

    img = cv2.cvtColor(img,cv2.COLOR_BGR2GRAY)

    kernel = np.ones((1, 1), np.uint8)
    img = cv2.dilate(img, kernel, iterations=1)
    img = cv2.erode(img, kernel, iterations=1)

    cv2.imwrite(src_path + "gray.png", img)
    b = pytesseract.image_to_string(Image.open(src_path +'gray.png'))
    text.append(b)



    img = cv2.adaptiveThreshold(img, 255,cv2.ADAPTIVE_THRESH_GAUSSIAN_C,cv2.THRESH_BINARY,115,1)

    cv2.imwrite(src_path + "thres.png", img)

    c = pytesseract.image_to_string(Image.open(src_path+'thres.png'))
    if(c=="UH8"):
        file = open("C:\\Users\\Public\\ROV\\OCR\\aa.txt","a")
        file.write("A")
        file.close()
        break
    elif(c=="L6R") :
        file = open("C:\\Users\\Public\\ROV\\OCR\\aa.txt", "a")
        file.write("B")
        file.close()
        break
    elif(c =="G7C") :
        file = open("C:\\Users\\Public\\ROV\\OCR\\aa.txt", "a" )
        file.write("C")
        file.close()
        break
    text.append(c)

    texta = len(text)
    file = open("C:\\Users\\Public\\ROV\\OCR\\aa", "a")

    for i in range(0,texta) :



        print(text[i])



        print("""  ____   """)
    time.sleep(10)
