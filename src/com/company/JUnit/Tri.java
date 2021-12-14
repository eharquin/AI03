package com.company;

import java.util.*;

public class Tri {
	public boolean compare(int ta1[], int ta2[])
	{
		int l1=ta1.length;
		int l2=ta2.length;
		for(int i=0;i<l1-1;i++)
		{
			if(ta1[i] !=ta2[i])
			{
				return(false);
			}
		}
		return(true);
	}


	public boolean estTrie(int tableau[])
	{
		int longueur=tableau.length;
		
		for(int i=0;i<longueur-1;i++)
		{
			if(tableau[i]>tableau[i+1])
			{
				return(false);
			}
		}
		return(true);
	}

	private void echanger(int tableau[],int i,int j)
	{
		int memoire=tableau[i];
		tableau[i]=tableau[j];
		tableau[j]=memoire;
	}
 
        
    /**
	*Le tri bulle optimis�
	*
	*/
	public void triBulleOptimise(int tableau[])
	{
		int longueur=tableau.length;
		boolean inversion;
		
		do
		{
			inversion=false;

			for(int i=0;i<longueur-1;i++)
			{
				if(tableau[i]>tableau[i+1])
				{
					echanger(tableau,i,i+1);
					inversion=true;
				}
			}
             		longueur--;
		}
		while(inversion);	
	}
			

	/**
	*Le tri selection
	*
	*/
	public void triSelection(int tableau[])
	{
		int longueur=(tableau.length-1);
		
		while (longueur>0)
		{
			//on recupere la position du plus grand �l�ment du tableau non encore tri�
			int maxi=0;
			for(int i=1;i<=longueur;i++)
			{
				if (tableau[i]>tableau[maxi]) 
					maxi=i;
			}
			echanger(tableau,maxi,longueur); 	//on met le plus grand �l�ment � la fin
			longueur--; 				//et on traite le reste du tableau !!!
		}
	}
		
}