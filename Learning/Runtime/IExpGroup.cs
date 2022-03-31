using System;

namespace EscuelaIT.TDD.Week.Runtime
{
    public interface IExpGroup
    {
        int ExpOf(int lvl);
    }

    class FastExpGroup : IExpGroup
    {
        public int ExpOf(int lvl)
        {
            return (int)(.8f * lvl * lvl * lvl);
        }
    }
    
    class SlowExpGroup : IExpGroup
    {
        public int ExpOf(int lvl)
        {
            if(lvl == 1)
                return 0;
            
            return (int)(1.25f * lvl * lvl * lvl);
        }
    }
    
    class MediumFastExpGroup : IExpGroup
    {
        public int ExpOf(int lvl)
        {
            if(lvl == 1)
                return 0;
            
            return lvl * lvl * lvl;
        }
    }
    
    class MediumSlowExpGroup : IExpGroup
    {
        public int ExpOf(int lvl)
        {
            return (int)((6 / 5f) * lvl * lvl * lvl
                - 15 * lvl * lvl
                + 100 * lvl
                - 140);
        }
    }
}