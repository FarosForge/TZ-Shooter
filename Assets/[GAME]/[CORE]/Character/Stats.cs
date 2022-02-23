public class Stats : IStats
{
    private int HP;

    public Stats(int hP)
    {
        HP = hP;
    }

    public void GetHit(int damage)
    {
        HP -= damage;

        if (HP <= 0) HP = 0;
    }

    public bool IsDead()
    {
        return HP <= 0;
    }
}
