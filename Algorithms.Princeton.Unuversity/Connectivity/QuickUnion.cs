using System;
namespace Algorithms.Princeton.Unuversity.Connectivity;

public class QuickUnion
{
	private int[] id; 
	public QuickUnion(int N)
	{
		id = new int [N];
		for (int i = 0; i < N; i++)
		{
			id[i] = i;
		}
	}

	// Chase parent point untill reach root
	// depth of i array accesses
	private int Root(int i)
	{
		while (i != id[i])
		{
			i = id[i];
		}

		return i;
	}

	// Check if p and q have the same root
	public bool IsConnected(int p, int q)
	{
		return Root(p) == Root(q);
	}

	// change root of p to point to root of q
	public void Union(int p, int q)
	{
		int i = Root(p);
		int j = Root(q);
		id[i] = j;
	}
}

