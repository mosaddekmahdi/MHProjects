package JavaWorldThreading;

class MyThread extends Thread
{
public void run ()
{
	setPriority(5);
   for (int count = 1, row = 1; row < 70; row++, count++)
   {
        for (int i = 0; i < count; i++)
             System.out.print ('*');
        System.out.print ('\n');
   }
   
   System.out.println("MyThread Priority is: " + getPriority());
}
}