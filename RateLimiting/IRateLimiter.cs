namespace RateLimiting
{
    internal interface IRateLimiter
    {
        bool GrantAccess();
    }
}
