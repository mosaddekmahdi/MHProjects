
	
import java.awt.event.*;

public class MyAction implements ActionListener {
    // this class defines the behavior of the buttons made in
    // the gui class, hence, the latter class must be declared
    // in order to gain access to those buttons
    private Gui myGUI;

    public MyAction(Gui getLogGUI) {
        // intantiates myGUI with the values of gui
        myGUI = getLogGUI;
    }

    public void actionPerformed(ActionEvent e) {

        Result a = new Result(myGUI.getComplete(), myGUI.getButtonA());
        PcMove b = new PcMove();

        // action for quit button
        if (e.getActionCommand() == "Quit") {
            System.exit(0);

            // action for new button
        } else if (e.getActionCommand() == "New") {
            // selecting player mode
            myGUI.setPlayerMode(a.selectMode());
            // does nothing if cancel is chosen
            // in selecting modes
            if (myGUI.getPlayerMode() < 2) {
                for (int i = 1; i < 10; i++) {
                    myGUI.getButton(i).setText("");
                    myGUI.getButton(i).setEnabled(true);

                }
                myGUI.setComplete(false);
                myGUI.setLeftBoxes(9);
                // playerMode 0 is playing against AI
                if (myGUI.getPlayerMode() == 0) {
                    myGUI.setIsAITurn(b.ifCPUMovesFirst());

                    // if true, AI selects first cell
                    if (myGUI.getIsAITurn()) {
                        int m = b.moveAI();
                        // computer is always O, player is X
                        myGUI.getButton(m).setText("O");
                        myGUI.getButton(m).setEnabled(false);
                        myGUI.reduceLeftBoxes();

                    }
                }
            }

            // action for the other buttons (the ones to mark with X or O)
        } else {
            myGUI.reduceLeftBoxes(); // if one cell is clicked, then one less
            // remaining un-clicked cells

            if (myGUI.getPlayerMode() == 0) { // 1 player mode
                for (int i = 1; i < 10; i++) { // player's move
                    if (e.getSource().equals(myGUI.getButton(i))) {
                        myGUI.getButton(i).setText("X");
                        myGUI.getButton(i).setEnabled(false);
                        myGUI.setXTurn(false);
                    }
                }
                myGUI.setComplete(a.preWin()); // AI won't move when player
                                                // wins even if some cells are
                                                // still available
                // AI response
                if (myGUI.getLeftBoxes() != 0 && myGUI.getComplete() == false) {
                    int m;
                    for (;;) {
                        m = b.moveAI();
                        if (myGUI.getButton(m).getText().equals("")) {
                            break;
                        }
                    }
                    myGUI.getButton(m).setText("O");
                    myGUI.getButton(m).setEnabled(false);
                    myGUI.reduceLeftBoxes();
                }

            } else if (myGUI.getPlayerMode() == 1) { // 2 player mode
                for (int i = 1; i < 10; i++) {

                    if (e.getSource().equals(myGUI.getButton(i))) {
                        if (myGUI.getXTurn()) {
                            myGUI.getButton(i).setText("X");
                            myGUI.getButton(i).setEnabled(false);
                            myGUI.getButton(0).setText("O Turn");
                            myGUI.setXTurn(false);
                        } else if (myGUI.getXTurn() == false) {
                            myGUI.getButton(i).setText("O");
                            myGUI.getButton(i).setEnabled(false);
                            myGUI.setXTurn(true);
                            myGUI.getButton(0).setText("X Turn");
                        }
                    }
                }
            }

            myGUI.setComplete(a.preWin()); // checking for win

            if (myGUI.getLeftBoxes() == 0 && myGUI.getComplete() == false) { // conditions
                // for draw
                a.declareDraw();
            }
        }

    }

}