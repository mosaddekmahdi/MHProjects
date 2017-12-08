package JavaWorldThreadName;

//NameThatThread.java
class NameThatThread
{
public static void main (String [] args)
{

   MyThread mt;
   if (args.length == 0)
       mt = new MyThread ();
   else
       mt = new MyThread (args [0]);
   mt.start ();
}
}
