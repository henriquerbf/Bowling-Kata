namespace Bowling_Kata
{
    public class Game
    {
        private readonly Frame[] Frames;

        public Game(int qtyFrames)
        {
            Frames = new Frame[qtyFrames];

            for (int i = 0; i < Frames.Length; i++)
            {
                SetFrameRolls(i);
            }
        }
        public void Roll(int qtyPinos)
        {
                    
        }

        public int Score()
        {
            return 0;
        }

        private void SetFrameRolls(int i)
        {
            if (i == Frames.Length - 1)
                Frames[i] = new Frame(3);
            else
                Frames[i] = new Frame(2);
        }

    }
}
