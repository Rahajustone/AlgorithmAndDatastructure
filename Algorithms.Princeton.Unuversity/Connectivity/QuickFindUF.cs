using System;
namespace Algorithms.Princeton.Unuversity.Connectivity;

public class QuickFindUF
{
	private int[] id { get; set; }

	public QuickFindUF(int n)
	{
		id = new int[n];
		for (int i = 0; i < n; i++)
		{
			id[i] = i;
		}
	}

	public bool IsConnected(int p, int q) => id[p] == id[q];

    // [1,2,3,4,5]
    // Union(1,2) =>2,2,3,4,5
    public void Union(int p, int q)
	{
		int pId = id[p];
		int qId = id[q];
		for (int i = 0; i < id.Length; i++)
		{
			if (id[i] == pId)
				id[i] = qId;
		}
	}
}
