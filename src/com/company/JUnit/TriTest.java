package com.company;

import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class TriTest {

    @Test
    void compare() {

    }

    @Test
    @DisplayName("Est trié")
    void estTrie() {
        Tri tri = new Tri();
        int val[] = {1, 2, 3};
        int val2[] = {5, 8, 1, 7, 2};
        int val3[] = {};
        int val4[] = {110, -20, 5, 8, 10, -6, -20};
        int val5[] = {8};
        int val6[] = {-1, 2, 5, 8, 9, 10};
        int val7[] = {1, 2, 3, 4, 0};
        int val8[] = {10, 2, 3, 4, 5, 6};
        assertAll(() -> assertTrue(tri.estTrie(val)),
                () -> assertFalse(tri.estTrie(val2)),
                () -> assertTrue(tri.estTrie(val3)),
                () -> assertFalse(tri.estTrie(val4)),
                () -> assertTrue(tri.estTrie(val5)),
                () -> assertTrue(tri.estTrie(val6)),
                () -> assertFalse(tri.estTrie(val7)),
                () -> assertFalse(tri.estTrie(val8)));
    }

    @Test
    @DisplayName("Tri à bulles optimisé")
    void triBulleOptimise() {
        Tri tri = new Tri();
        int val[] = {1, 2, 3};
        int val2[] = {5, 8, 1, 7, 2};
        int val3[] = {};
        int val4[] = {110, -20, 5, 8, 10, -6, -20};
        tri.triBulleOptimise(val);
        tri.triBulleOptimise(val2);
        tri.triBulleOptimise(val3);
        tri.triBulleOptimise(val4);
        assertAll(() -> assertArrayEquals(new int[]{1, 2, 3}, val),
        () -> assertArrayEquals(new int[]{1, 2, 5, 7, 8}, val2),
        () -> assertArrayEquals(new int[]{}, val3),
        () -> assertArrayEquals(new int[] {-20, -20, -6, 5, 8, 10, 110}, val4));
    }

    @Test
    void triSelection() {
    }
}