// Build: 4ec3bc4fa9c87e67ec090354fc5dcb8c
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
