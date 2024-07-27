# Chocolate Sharing Problem - HackerRank

This project solves a HackerRank problem where you need to count the number of ways a chocolate bar can be divided into contiguous segments that meet specific criteria.

## Problem Description

Determine how many contiguous segments of a chocolate bar have:
1. Length equal to Ron's birth month (`m`).
2. Sum equal to Ron's birth day (`d`).

## Solution

The solution uses a sliding window technique to efficiently count valid segments.

### Function

```csharp
public static int birthday(List<int> s, int d, int m)
```
Parameters:

s: List of integers (chocolate values).
d: Birth day (sum of the segment).
m: Birth month (length of the segment).
Returns: Number of valid segments.

### How to Run
Compile the C# code.
Run the program with your inputs.
clone the repo:
`git clone https://github.com/IgorSantanaM/SubarrayDivsion.git`
