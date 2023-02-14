namespace Assets.skripts
{
    public interface IButton
    {
        void ButtorEXIT();
        void ButtorPlay();
        bool Equals(object other);
        int GetHashCode();
        string ToString();
    }
}