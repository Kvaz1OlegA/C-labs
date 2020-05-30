TARGET = magic.exe
CC = cl
CFLAGS = -c -Wall

.PHONY: edit run clean

edit: $(TARGET)		 
	
lab7.o: lab7.c
	$(CC) $(CFLAGS) lab5.c

$(TARGET): lab7.obj
	$(CC) lab7.obj -o $(TARGET)
	
splint:
	splint *.c
clean:
			@del -rf *.obj *.i *.s *.gch *.out *.exe
run:
			$(TARGET)