TARGET = magic.exe
CC = cl
CFLAGS = -c -Wall

.PHONY: edit run clean

edit: $(TARGET)		 
	
lab5.o: lab5.c
	$(CC) $(CFLAGS) lab5.c

$(TARGET): lab5.obj
	$(CC) lab5.obj -o $(TARGET)
	
splint:
	splint *.c
clean:
			@del -rf *.obj *.i *.s *.gch *.out *.exe
run:
			$(TARGET)