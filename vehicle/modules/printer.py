from datetime import datetime
logpad = open("log.txt", "w") # May need full path here

def error_decorator(error_func):
    def wrapper(*arg):
        print("ERROR: ", end="", file = logpad)
        return error_func(*arg)
    return wrapper

@error_decorator
def log(log_msg):
    print(str(datetime.now()) + "\t" + log_msg, file = logpad)

@error_decorator
def log_error(error_msg):
    print(str(datetime.now()) + "\t" + error_msg, file = logpad)
