package page;

import java.util.*;

public class Page {
	
	List<Integer> pt1 = new ArrayList<Integer>();
	List<Integer> pt2 = new ArrayList<Integer>();
	int[] address = {0, 1, 1, 0, 0, 1, 1, 1};
	int pageNum = 0;
	int offset = 0;

	public void run() {
		System.out.println("pt1");
		int memoryFrames1 = 5;
		pt1.add(memoryFrames1);
		int numProcesses1 = 5;
		pt1.add(numProcesses1);
		int numPages1 = 10;
		System.out.println("\nnumber of pages/ process = " + numPages1 / numProcesses1);
		pt1.add(numPages1);
		int pID1 = 1;
		System.out.println("\npID1 of every process = " + pID1);
		pt1.add(pID1);
		int processFrames1 = 10;
		pt1.add(processFrames1);
		System.out.println("\npt1 = " + pt1);
		while (numProcesses1 > 0 && processFrames1 > 0) {
			processFrames1--;
			pt1.set(4, processFrames1);
			memoryFrames1++;
			pt1.set(0, memoryFrames1);
			numProcesses1--;
			pt1.set(1, numProcesses1);
			pt1.set(2, numProcesses1 * 2);
			System.out.println("\npt1 = " + pt1);
			if (processFrames1 == 0) {
				System.out.println("\nProcess " + numProcesses1 + " doesn't have a frame.");
			}
		}

		System.out.println("___________________________________");
		System.out.println("pt2");
		int memoryFrames2 = 5;
		pt2.add(memoryFrames2);
		int numProcesses2 = 5;
		pt2.add(numProcesses2);
		int numPages2 = 5;
		System.out.println("\nnumber of pages/ process = " + numPages2 / numProcesses2);
		pt2.add(numPages2);
		int pID2 = 1;
		System.out.println("\npID2 of every process = " + pID2);
		pt2.add(pID2);
		int processFrames2 = 3;
		pt2.add(processFrames2);
		System.out.println("\npt2 = " + pt2);
		while (numProcesses2 > 0 && processFrames2 > 0) {
			processFrames2--;
			pt2.set(4, processFrames2);
			memoryFrames2++;
			pt2.set(0, memoryFrames2);
			numProcesses2--;
			pt2.set(1, numProcesses2);
			pt2.set(2, numProcesses2);
			System.out.println("\npt2 = " + pt2);
			if (processFrames2 == 0) {
				System.out.println("\nProcess " + numProcesses2 + " doesn't have a frame.");
			}
		}

		for (int i = 0; i < 4; i++) {
			pageNum += address[i] * Math.pow(2, i);
			offset += address[address.length - i - 1] * Math.pow(2, i);
		}

		System.out.println("___________________________________");
		System.out.println("\npageNum = " + pageNum);
		System.out.println("\noffset = " + offset);
	}
}