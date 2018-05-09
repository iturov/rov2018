
import pyscreenshot as ImageGrab


i=0
src_path ="C:\\Users\\Public\\ROV\OCR\\"


if __name__ == "__main__":
    # part of the screen
    im=ImageGrab.grab(bbox=(200,100,1100,600)) # X1,Y1,X2,Y2
    im.save(src_path + 'init.png')



