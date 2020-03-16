package philosopher;

public class Philosopher{
	public String[] stateArray = new String [5];
	public String thinking = "thinking";
	public String eating = "eating";
	public int count = 0;

	public void run() {
		while (count < 500) {
			for (int i = 0; i < stateArray.length; i++) {
				if (Math.floor(Math.random() * 2.0) == 0.0) {
					stateArray[i] = thinking;
					System.out.println("Philosopher " + i + " is " + stateArray[i] + ".");
				}
				
				else{
					if (stateArray[(i + 1) % 5] != eating && stateArray[(i + 4) % 5] != eating) {
						stateArray[i] = eating;
						System.out.println("Philosopher " + i +" is " + stateArray[i] + ".");
						count++;
						System.out.println("The philosophers have eaten " + count + " time(s).");
						if (count == 500) {
							break;
						}
					}
				}
			}
		}
	}
}