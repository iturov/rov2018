import PIL
from PIL import Image
import cv2
import numpy as np
import pyscreenshot as ImageGrab
import time

i=0
src_path =src_path="C:\\Users\\Public\\ROV\\OCR\\"
time.sleep(4)
while(i<10000000):

    if __name__ == "__main__":
        # part of the screen
        im=ImageGrab.grab(bbox=(100,100,1100,640)) # X1,Y1,X2,Y2

        im.save(src_path + 'init.png')
        im.show()

        time.sleep(35)
    i+=1