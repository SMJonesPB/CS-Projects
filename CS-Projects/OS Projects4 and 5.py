import random

stateArray = ["thinking", "thinking", "thinking", "thinking", "thinking"]
thinking = "thinking"
eating = "eating"
count = 0

while count < 500:
	for i in range(0, len(stateArray)):
		if random.randint(0, 1) == 0:
			stateArray[i] = thinking
			print("Philosopher", i, "is", stateArray[i], ".")
			
		else:
			if stateArray[(i + 1) % 5] == thinking and stateArray[(i + 4) % 5] == thinking:
				stateArray[i] = eating
				print("Philosopher", i, "is", stateArray[i], ".")
				count += 1
				print("The philosophers have eaten", count, "time(s).")
				if count == 500:
					break

pt1 = [0, 0, 0, 0, 0]
pt2 = [0, 0, 0, 0, 0]
address = [0, 1, 1, 0, 0, 1, 1, 1]
pageNum = 0
offset = 0

print("\n\npt1\n")
memoryFrames1 = 5
pt1[0] = memoryFrames1
numProcesses1 = 5
pt1[1] = numProcesses1
numPages1 = 10
print("number of pages/ process =", int(numPages1 / numProcesses1))
pt1[2] = numPages1
pID1 = 1
print("pID1 of every process =", pID1)
pt1[3] = pID1
processFrames1 = 10
pt1[4] = processFrames1
print("pt1 = [", ", ".join(str(i) for i in pt1), "]")
while numProcesses1 > 0 and processFrames1 > 0:
	processFrames1 -= 1
	pt1[4] = processFrames1
	memoryFrames1 += 1
	pt1[0] = memoryFrames1
	numProcesses1 -= 1
	pt1[1] = numProcesses1
	pt1[2] = numProcesses1 * 2
	print("pt1 = [", ", ".join(str(i) for i in pt1), "]")
	if processFrames1 == 0:
		print("Process", numProcesses1, "doesn't have a frame.")
		
print("___________________________________")
print("pt2\n")
memoryFrames2 = 5
pt2[0] = memoryFrames2
numProcesses2 = 5
pt2[1] = numProcesses2
numPages2 = 5
print("number of pages/ process =", int(numPages2 / numProcesses2))
pt2[2] = numPages2
pID2 = 1
print("pID2 of every process =", pID2)
pt2[3] = pID2
processFrames2 = 3
pt2[4] = processFrames2
print("pt2 = [", ", ".join(str(i) for i in pt2), "]")
while numProcesses2 > 0 and processFrames2 > 0:
	processFrames2 -= 1
	pt2[4] = processFrames2
	memoryFrames2 += 1
	pt2[0] = memoryFrames2
	numProcesses2 -= 1
	pt2[1] = numProcesses2
	pt2[2] = numProcesses2 * 2
	print("pt2 = [", ", ".join(str(i) for i in pt2), "]")
	if processFrames2 == 0:
		print("\nProcess", numProcesses2, "doesn't have a frame.")
		
for i in range(0, 4):
	pageNum += address[i] * 2 ** i
	offset += address[len(address) - i - 1] * 2 ** i
	
print("___________________________________")
print("pageNum =", pageNum)
print("offset =", offset)