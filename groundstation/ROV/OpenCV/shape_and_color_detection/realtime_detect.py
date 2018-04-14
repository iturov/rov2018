import numpy as np
import cv2
from modules.shape_detector import ShapeDetector
import imutils

cam = cv2.VideoCapture(0)

def find_shape(image):
    gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
    blurred = cv2.GaussianBlur(gray, (5, 5), 0)
    return cv2.threshold(blurred, 30, 255, cv2.THRESH_BINARY)[1]

def color_mask(image, color = "Red"):
    if color == "Blue":
        boundary = blueboundaries = [([55, 1, 1], [255, 80, 80])]
    elif color == "Green":
        boundary = greenboundaries = [([1, 55, 1], [80, 255, 80])]
    else:
        boundary = redboundaries = [([1, 1, 55], [80, 80, 255])]

    for (lower, upper) in boundary:
        lower = np.array(lower, dtype = "uint8")
        upper = np.array(upper, dtype = "uint8")

        mask = cv2.inRange(image, lower, upper)
        return cv2.bitwise_and(image, image, mask = mask)

while True:
    ret, image = cam.read()
    resized = imutils.resize(image, width=300)
    ratio = image.shape[0] / float(resized.shape[0])

    filtered = color_mask(image, color = "Red")
    #blurr = cv2.GaussianBlur(image, (7,7), 0)
    threshed = find_shape(filtered)

    contours = cv2.findContours(threshed.copy(), cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)
    contours = contours[0] if imutils.is_cv2() else contours[1]
    sd = ShapeDetector()
    c = contours[0]
    M = cv2.moments(c)
    try:
        cX = int((M['m10'] / M['m00'])* ratio)
        cY = int((M['m01'] / M['m00'])* ratio)
    except (ZeroDivisionError):
        cX = 15
        cY = 15
    shape = sd.detect(c)
    c = c.astype("float")
    c *= ratio
    c = c.astype("int")
    cv2.drawContours(image, [c], -1, (0, 255, 0), 2)
    cv2.putText(image, shape, (cX, cY), cv2.FONT_HERSHEY_SIMPLEX, 0.5, (255, 255, 255), 2)
    cv2.imshow("Thresh", threshed)
    cv2.imshow("Shape + Color", image)
    if cv2.waitKey(1) & 0xFF == ord('q'):
        break
cam.release()
cv2.destroyAllWindows()
