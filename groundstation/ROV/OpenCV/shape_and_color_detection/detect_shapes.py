from modules.shape_detector import ShapeDetector
import imutils
import cv2

#image = cv2.imread("modules/shapes_and_colors.jpg")
cam = cv2.VideoCapture(0)
t, image = cam.read()

resized = cv2.resize(image, None, fx=0.5, fy=0.5, interpolation = cv2.INTER_CUBIC)
ratio = image.shape[0] / float(resized.shape[0])

gray = cv2.cvtColor(resized, cv2.COLOR_BGR2GRAY)
blurred = cv2.GaussianBlur(gray, (5, 5), 0)
thresh = cv2.threshold(blurred, 127, 255, cv2.THRESH_BINARY)[1]

contours = cv2.findContours(thresh.copy(), cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)
contours = contours[0] if imutils.is_cv2() else contours[1]

sd = ShapeDetector()

for c in contours:
    M = cv2.moments(c)
    try:
        cX = int((M['m10'] / M['m00'])* ratio)
        cY = int((M['m01'] / M['m00'])* ratio)
    except (ZeroDivisionError):
        cX = 0
        cY = 0
    shape = sd.detect(c)
    c = c.astype("float")
    c *= ratio
    c = c.astype("int")
    cv2.drawContours(image, [c], -1, (0, 255, 0), 2)
    cv2.putText(image, shape, (cX, cY), cv2.FONT_HERSHEY_SIMPLEX, 0.5, (255, 255, 255), 2)
    cv2.imshow("Image", image)
    cv2.imshow("Thresh", thresh)
    cv2.imwrite("modules/shot.jpg", image)
    cv2.waitKey()
cam.release()
cv2.destroyAllWindows()
