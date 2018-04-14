import pyscreenshot as ImageGrab
import cv2
import numpy as np
import pytesseract
from PIL import Image

src_path = "C:\\Users\\Public\\ROV\\OCR\\"
if __name__ == "__main__":
    # fullscreen
    im=ImageGrab.grab()
    im.show()
    im.save('init.png')

text=[]
a = pytesseract.image_to_string(Image.open('init.png'))
text.append(a)
img = cv2.imread('init.png')

img = cv2.cvtColor(img,cv2.COLOR_BGR2GRAY)

kernel = np.ones((1, 1), np.uint8)
img = cv2.dilate(img, kernel, iterations=1)
img = cv2.erode(img, kernel, iterations=1)

cv2.imwrite(src_path + "gray.png", img)
b = pytesseract.image_to_string(Image.open('gray.png'))
text.append(b)



img = cv2.adaptiveThreshold(img, 255,cv2.ADAPTIVE_THRESH_GAUSSIAN_C,cv2.THRESH_BINARY,115,1)

cv2.imwrite(src_path + "thres.png", img)

c = pytesseract.image_to_string(Image.open('thres.png'))

text.append(c)

texta = len(text)
f= open("C:\\Users\\Public\\ROV\\OCR\\model.txt","w+")
for i in range(0,texta):
    f.write(text[i])
f.close()
