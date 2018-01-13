import matplotlib.pyplot as plt
import matplotlib.animation as animation
from matplotlib import style

style.use('seaborn-darkgrid')

fig = plt.figure()
axis1 = fig.add_subplot(1,1,1)

def animate(i):
    graph_data = open('/home/enes/Desktop/rov2018/groundstation/modules/seismograph/data.txt','r').read()
    lines = graph_data.split('\n')
    xs = []
    ys = []
    for line in lines:
        if len(line) > 1:
            x , y = line.split(',')
            xs.append(float(x))
            ys.append(float(y))
    axis1.clear()
    axis1.plot(xs, ys)

ani = animation.FuncAnimation(fig, animate, interval = 500)
plt.show()