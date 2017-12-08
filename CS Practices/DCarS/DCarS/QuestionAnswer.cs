using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace DCarS
{
    public partial class QuestionAnswer : Form
    {
        public int TotalNumberOfQuestions;

        // This variable will hold a list of randoom non-repeating numbers
        ArrayList lstNumbers;
        // This will represent the index of the question that is being asked
        int CurrentQuestion;
        // These will keep a count of the questions already asked
        int QuestionCounter;
        int CurrentNumberOfQuestions;
        // This will be used to counte the number of correct answers
        double Sum;
        const int MaximumNumberOfQuestions = 20;
        // This variable allows monitoring if a 0 had been
        // added to the list of numbers;
        bool Found0;
        int count = 0;

        public QuestionAnswer()
        {
            InitializeComponent();
        }

        // This method takes a constant integer that represents
        // the index of a question in the list of questions
        // This method then displays the corresponding question
        void PresentQuestion(int qstNumber)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            count++;
            label2.Text = count.ToString();
            label4.Text = TotalNumberOfQuestions.ToString();


            switch (qstNumber)
            {
                case 1:
                    txtQuestion.Text = "If your car and a car coming from your " +
                                       "right reach an intersection at the same " +
                                       "time, who has the right of way?";

                    radioButton1.Text = "A. Your car";
                    radioButton2.Text = "B. The other car";
                    radioButton3.Text = "C. You both wait for the first car that makes a move";
                    radioButton4.Text = "D. Neither, as both cars must come to a stop";
                    break;

                case 2:
                    txtQuestion.Text = "How many feet before you make a turn should " +
                                       "you signal that you are going to turn?";

                    radioButton1.Text = "A. 50 feet";
                    radioButton2.Text = "B. 100 feet";
                    radioButton3.Text = "C. 150 feet";
                    radioButton4.Text = "D. While turning";

                    break;

                case 3:
                    txtQuestion.Text = "You are driving in an alley at fifteen (15) " +
                                       "miles per hour. You are";

                    radioButton1.Text = "A. Breaking the speed limit for alleys";
                    radioButton2.Text = "B. Driving too slow";
                    radioButton3.Text = "C. Obeying the law";
                    radioButton4.Text = "D. Breaking the law as you should never drive " +
                                      "in an alley";
                    break;

                case 4:
                    txtQuestion.Text = "A car driving toward you " +
                                       "at night and it has its blinding " +
                                       "high beam lights on. The driver of this car is";

                    radioButton1.Text = "A. Guilty only of bad manners because the " +
                                      "high beams blind other drivers";
                    radioButton2.Text = "B. A safe driver because the high beams " +
                                      "light up the road more brightly than " +
                                      "the lower beams";
                    radioButton3.Text = "C. Not obeying the law because the low beams " +
                                      "must be used at all times";
                    radioButton4.Text = "D. not doing anything wrong (it doesn't matter";
                    break;

                case 5:
                    txtQuestion.Text = "You are driving up to an intersection where " +
                                       "there is no signal light or policeman. A man " +
                                       "is crossing in the cross walk in front of " +
                                       "your car. You should:";

                    radioButton1.Text = "A. Continue into the intersection because you " +
                                      "have the right-of-way";
                    radioButton2.Text = "B. Slow down and be careful";
                    radioButton3.Text = "C. Stop and give him the right-of way";
                    radioButton4.Text = "D. Not care";
                    break;

                case 6:
                    txtQuestion.Text = "You wish to make a \"U\" turn at an intersection " +
                                       "controlled by a traffic light. You should: ";

                    radioButton1.Text = "A. Drive to another intersection that has no traffic " +
                                      "light or sign saying NO \"U\" Turn";
                    radioButton2.Text = "B. Wait until the light turns green before making " +
                                      "the \"U\" turn";
                    radioButton3.Text = "C. Make the \"U\" turn if there is a policeman " +
                                      "at the intersection";
                    radioButton4.Text = "D. Wait for the red light before making the \"U\" " +
                                      "turn to make sure that the opposing traffic is safe";
                    break;

                case 7:
                    txtQuestion.Text = "You are driving past a school building or its " +
                                       "grounds when the children are going to or " +
                                       "leaving school. The speed limit is:";

                    radioButton1.Text = "A. Seven (7) miles per hour";
                    radioButton2.Text = "B. Fifteen (15) miles per hour";
                    radioButton3.Text = "C. Ten (10) miles per hour";
                    radioButton4.Text = "D. Twenty (20) miles per hour";
                    break;

                case 8:
                    txtQuestion.Text = "If you are driving out of an alley " +
                                       "or driveway, you must";

                    radioButton1.Text = "A. Stop before reaching the sidewalk";
                    radioButton2.Text = "B. Stop, if possible to do so safely";
                    radioButton3.Text = "C. Stop only if there is heavy traffic";
                    radioButton4.Text = "D. Wait for a policeman of respectable " +
                                      "pedestrian to guide you when it is safer";
                    break;

                case 9:
                    txtQuestion.Text = "You are coming to an intersection " +
                                       "where there is a flashing yellow traffic " +
                                       "light. You should";

                    radioButton1.Text = "A. Slow down and proceed with caution";
                    radioButton2.Text = "B. Stop, if possible to do so safely";
                    radioButton3.Text = "C. Continue at the same speed";
                    radioButton4.Text = "D. Wait for a poileman to direct the traffic";
                    break;

                case 10:
                    txtQuestion.Text = "You are driving on a two-lane street. " +
                                       "The car ahead of you is moving very slowly " +
                                       "and the road ahead is clear for passing. " +
                                       "You should:";

                    radioButton1.Text = "A. Pass on the left hand side";
                    radioButton2.Text = "B. Pass on either side";
                    radioButton3.Text = "C. Pass on the right side";
                    radioButton4.Text = "D. Make a gesture to signal the other car " +
                                      "to move to the other lane, so you can " +
                                      "drive straight";
                    break;

                case 11:
                    txtQuestion.Text = "What is the legal rate of speed " +
                                       "unless there are signs " +
                                       "that give a different speed limit?";

                    radioButton1.Text = "A. 25 miles per hour";
                    radioButton2.Text = "B. 30 miles per hour";
                    radioButton3.Text = "C. 35 miles per hour";
                    radioButton4.Text = "D. 45 miles per hour";
                    break;

                case 12:
                    txtQuestion.Text = "You are driving a car which is involved in " +
                                       "an accident. Two people are slightly hurt " +
                                       "but don't need to go to the hospital. " +
                                       "You should:";

                    radioButton1.Text = "A. Report to the nearest police pricinct";
                    radioButton2.Text = "B. Report to the Department of Motor Vehicles";
                    radioButton3.Text = "C. Report to the police and the Department of " +
                                      "Motor Vehicles";
                    radioButton4.Text = "D. Wait for a policeman";
                    break;

                case 13:
                    txtQuestion.Text = "You're driving up to an intersection where " +
                                       "the traffic light is red. A policeman " +
                                       "motions you to go through. You should";

                    radioButton1.Text = "A. Wait for the light to turn green and " +
                                      "then go ahead";
                    radioButton2.Text = "B. Call the policeman's attention to " +
                                      "the red light";
                    radioButton3.Text = "C. Obey the policeman's signal";
                    radioButton4.Text = "D. Wait for another car to move to make " +
                                      "sure the road is safe";
                    break;

                case 14:
                    txtQuestion.Text = "You are pulling into the street from a " +
                                       "parallel parking space. Before doing " +
                                       "so, you should:";

                    radioButton1.Text = "A. Blow your horn and pull from the curb slowly";
                    radioButton2.Text = "B. Signal other traffic and then pull into the street";
                    radioButton3.Text = "C. Proceed with caution when there is no traffic " +
                                      "near enough to cause an accident";
                    radioButton4.Text = "D. Wait for a policeman or a respectable citizen " +
                                      "to signal that the road is safer";
                    break;

                case 15:
                    txtQuestion.Text = "You have changed your address. You should notify " +
                                       "the Department of Motor Vehicles, either by " +
                                       "mail or in person, within a period of:";

                    radioButton1.Text = "A. Fifteen (15) days";
                    radioButton2.Text = "B. Five (5) days";
                    radioButton3.Text = "C. Thirty (30) days";
                    radioButton4.Text = "D. Ten (10) days";
                    break;

                case 16:
                    txtQuestion.Text = "You are driving on a street and another car is " +
                                       "entering the street from a driveway. Who has " +
                                       "the right-of-way?";

                    radioButton1.Text = "A. You";
                    radioButton2.Text = "B. The other driver";
                    radioButton3.Text = "C. Neither you nor the other driver";
                    radioButton4.Text = "D. The next car";
                    break;

                case 17:
                    txtQuestion.Text = "Up to what age are children required to " +
                                       "be restrained in a child restraint seat?";

                    radioButton1.Text = "A. 6 months old";
                    radioButton2.Text = "B. 3 years";
                    radioButton3.Text = "C. 6 years";
                    radioButton4.Text = "D. 8 years";
                    break;

                case 18:
                    txtQuestion.Text = "How close to a fire hydrant (fire plug) " +
                                       "may you park a motor vehicle?";

                    radioButton1.Text = "A. Five (5) feet";
                    radioButton2.Text = "B. Six (6) feet";
                    radioButton3.Text = "C. Ten (10) feet";
                    radioButton4.Text = "D. It doesn't matter because you will " +
                                      "move your car if the fire fighters request it";
                    break;

                case 19:
                    txtQuestion.Text = "When the light is green and the yellow " +
                                       "light comes on as you approach an " +
                                       "intersection, you should";

                    radioButton1.Text = "A. Hurry to cross";
                    radioButton2.Text = "B. Stop the crosswalk";
                    radioButton3.Text = "C. Proceed accross the intersection with caution";
                    radioButton4.Text = "D. Before deciding about what to do, check if the " +
                                      "intersection is equipped with cameras";
                    break;

                case 20:
                    txtQuestion.Text = "A flashing red traffic light signals means the same as:";

                    radioButton1.Text = "A. Stop sign";
                    radioButton2.Text = "B. Yield right-of-way sign";
                    radioButton3.Text = "C. Slow sign";
                    radioButton4.Text = "D. An ambulance is approaching";
                    break;

                case 21:
                    txtQuestion.Text = "How close to the intersection are you allowed " +
                                       "to park on a two-way street?";

                    radioButton1.Text = "A. Twenty (20) feet";
                    radioButton2.Text = "B. Thirt (30) feet";
                    radioButton3.Text = "C. Fourty (40) feet";
                    radioButton4.Text = "D. Fifty (50) feet";
                    break;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            double average = 1;

            if (QuestionCounter != 0)
                average = Sum / QuestionCounter;
            string strCongratulations = "";

            if (average >= 0.5)
                strCongratulations = "\nCongratulations!";

            if (Found0 == true)
                QuestionCounter--;

            MessageBox.Show("Total Number of Questions: " +
                            QuestionCounter.ToString() +
                            "\nNumber of Correct Answers: " +
                            Sum.ToString() +
                            "\nSuccess Rate: " +
                            (average * 100).ToString("F") +
                            " %\n" + strCongratulations);
            lstNumbers.Remove(MaximumNumberOfQuestions);
            Close();
        }

        // This method takes as argument a constant integer
        // The argument represents a question that was 
        // previously asked. The method checks the indexed 
        // question against its valid answer. If the answer 
        // to the question is valid, a total value is increased
        void CheckAnswer(int qstNumber)
        {
            switch (qstNumber)
            {
                case 1:
                    if (radioButton2.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer. \n" +
                            "The correct answer is B");
                    break;

                case 2:
                    if (radioButton2.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                            "The correct answer is B");
                    break;

                case 3:
                    if (radioButton3.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                             "The correct answer is C");
                    break;

                case 4:
                    if (radioButton3.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                             "The correct answer is C");
                    break;

                case 5:
                    if (radioButton3.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                            "The correct answer is C");
                    break;

                case 6:
                    if (radioButton1.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                            "The correct answer is A");
                    break;

                case 7:
                    if (radioButton2.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                             "The correct answer is B");
                    break;

                case 8:
                    if (radioButton1.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                             "The correct answer is A");
                    break;

                case 9:
                    if (radioButton1.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                            "The correct answer is A");
                    break;

                case 10:
                    if (radioButton1.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                            "The correct answer is A");
                    break;

                case 11:
                    if (radioButton1.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                             "The correct answer is A");
                    break;

                case 12:
                    if (radioButton3.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                             "The correct answer is C");
                    break;

                case 13:
                    if (radioButton3.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                            "The correct answer is C");
                    break;

                case 14:
                    if (radioButton3.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                            "The correct answer is C");
                    break;

                case 15:
                    if (radioButton2.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                            "The correct answer is B");
                    break;

                case 16:
                    if (radioButton1.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                            "The correct answer is A");
                    break;

                case 17:
                    if (radioButton2.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                            "The correct answer is B");
                    break;

                case 18:
                    if (radioButton3.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                            "The correct answer is C");
                    break;

                case 19:
                    if (radioButton2.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                             "The correct answer is B");
                    break;

                case 20:
                    if (radioButton1.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                             "The correct answer is A");
                    break;

                case 21:
                    if (radioButton3.Checked == true)
                    {
                        MessageBox.Show("Correct answer!");
                        Sum++;
                    }
                    else
                        MessageBox.Show("Wrong Answer \n" +
                            "The correct answer is C");
                    break;
            }

            if (CurrentNumberOfQuestions == (TotalNumberOfQuestions + 1))
            {
                btnQuit_Click(null, null);
            }
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            CurrentNumberOfQuestions++;
            CheckAnswer(CurrentQuestion);

            if (QuestionCounter >= lstNumbers.Count)
                return;
            CurrentQuestion = (int)(lstNumbers[QuestionCounter++]);

            if (CurrentQuestion == 0)
            {
                Found0 = true;
                CurrentQuestion = (int)(lstNumbers[QuestionCounter++]);
            }

            PresentQuestion(CurrentQuestion);
        }

        private void QuestionAnswer_Load(object sender, EventArgs e)
        {
            Found0 = false;
            QuestionCounter = 0;

            CurrentNumberOfQuestions = 0;

            lstNumbers = new ArrayList();
            Random rndNumber = new Random();

            int number = rndNumber.Next(1, MaximumNumberOfQuestions + 1);
            lstNumbers.Add(number);
            int count = 0;
            
            // Create a list of 20 non-repeating integers randomly chosen
            do
            {
                // Randomly choose between 1 and the MaximumNumberOfQuestions
                number = rndNumber.Next(0, MaximumNumberOfQuestions + 1);

                // If the chosen number is not yet in the list,
                // then add it
                if (!lstNumbers.Contains(number))
                {
                    lstNumbers.Add(number);
                }// If the number is already in the list, ignore it

                count++;
              

            } while (count <= 100);

            btnCheckAnswer_Click(sender, e);
        }

        private void btnQuite_Click(object sender, EventArgs e)
        {
            double average = 1;

            if (QuestionCounter != 0)
                average = Sum / QuestionCounter;
            string strCongratulations = "";

            if (average >= 50)
                strCongratulations = "\nGood job, Congratulations!";

            if (Found0 == true)
                QuestionCounter--;

            MessageBox.Show("Total Number of Questions: " +
                            QuestionCounter.ToString() +
                            "\nNumber of Correct Answers: " +
                            Sum.ToString() +
                            "\nSuccess Rate: " + (average * 100).ToString("F") + "%" + strCongratulations);
            lstNumbers.Remove(MaximumNumberOfQuestions);
            Close();

        }

    }
}