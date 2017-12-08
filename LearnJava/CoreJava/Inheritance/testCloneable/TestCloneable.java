package testCloneable;

import differentPackage.MyClass;

public class TestCloneable {

	public static void main(String [] args) throws CloneNotSupportedException {
		
		MyClass A1 = new MyClass();
		A1.setA(10);
		A1.setCh('z');
		
		// try to clone A1
		//MyClass A2 = new MyClass();
		String str = A1.toString();
		
		TestCloneable B1 = new TestCloneable();
		TestCloneable B2 = (TestCloneable) B1.clone();
		
		class AnotherTestCloneable {
			
			TestCloneable C1 = new TestCloneable();

		}
		
	}
}
