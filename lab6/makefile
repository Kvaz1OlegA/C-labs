TARGET = magic.exe
CC = cl
CFLAGS = -c -Wall

.PHONY: edit run clean

edit: $(TARGET)		 
	
lab6.o: lab6.c
	$(CC) $(CFLAGS) lab6.c

$(TARGET): lab6.obj
	$(CC) lab6.obj -o $(TARGET)
	
splint:
	splint *.c
clean:
			@del -rf *.obj *.i *.s *.gch *.out *.exe
run:
			$(TARGET)
