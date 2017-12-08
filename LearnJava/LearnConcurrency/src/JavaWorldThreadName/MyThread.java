package JavaWorldThreadName;

class MyThread extends Thread
{
MyThread ()
{
   // The compiler creates the byte code equivalent of super ();
}
MyThread (String name)
{
   super (name); // Pass name to Thread superclass
}
public void run ()
{
   System.out.println ("My name is: " + getName ());
   System.out.println ("My priority is: " + getPriority ());
}
}