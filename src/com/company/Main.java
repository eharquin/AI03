package com.company;

import junit.framework.Test;
import junit.textui.TestRunner;


public class Main {

    public static void main(String[] args) {
	    Tri tri = new Tri();
        int val[] = {5, 8, 1, 7, 2};
        for(int i = 0; i < val.length; i++){
            System.out.print(val[i] + " ");
        }
        tri.triBulleOptimise(val);
        System.out.println("");
        for(int i = 0; i < val.length; i++){
            System.out.print(val[i] + " ");
        }
    }
}
