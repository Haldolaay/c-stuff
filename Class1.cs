using System;

public class Class1
{
	public Class1()
	{
		
	}
	
}

class Node {
	public int value;
	public Node right;
	public Node left;
		
}
public boolean isTrue(Node n) {

	return isTrue(n, Integer.MIN_VALUE, Integer.MAX_VALUE);

}
public boolean isTrue(Node n, int min, int max) {
	if (n == null) return true;
	if (n < min || n > max) return false;
	return isTrue(n.left, min, n.value) && isTrue(n.right, n.value + 1, max);
}
