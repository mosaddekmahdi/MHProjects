

 // Available at: http://www.conanhughes.com/2011/11/introduction-at-some-point-in-your-life.html
	 

public class TicTacToeMain {
    // any Java code will not run with the main method
    
	public static void main(String[] args) {
        // class main calls for another class, gui
        Gui g = new Gui();
        // within gui class g is launchFrame,
        // used to launch a graphical user interface
        g.launchFrame();
    }
}

