import numpy as np
import cv2

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

    filtered = color_mask(image, color = "Red")
    threshed = find_shape(filtered)

    #grayfilter = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
    #merged = cv2.bitwise_and(threshed, grayfilter)
    threshed_scaled = cv2.resize(threshed, None, fx=0.7, fy=0.7, interpolation = cv2.INTER_CUBIC)
    image_scaled = cv2.resize(image, None, fx=0.7, fy=0.7, interpolation = cv2.INTER_CUBIC)
    filtered_scaled = cv2.resize(filtered, None, fx=0.7, fy=0.7, interpolation = cv2.INTER_CUBIC)
    cv2.imshow('Thresh', threshed_scaled)
    cv2.imshow('Filter', np.hstack([image_scaled, filtered_scaled]))
    if cv2.waitKey(1) & 0xFF == ord('q'):
        break

cam.release()
cv2.destroyAllWindows()
