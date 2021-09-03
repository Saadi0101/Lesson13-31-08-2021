using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.GetWrite();
        }
    }

    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecordable
    {
        void Record();
        void PauseRec();
        void StopRec();
    }
    class Player: IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("PlaySound");
        }
        public void Pause()
        {
            Console.WriteLine("PauseSound");
        }
        public void Stop()
        {
            Console.WriteLine("StopSound");
        }
        public void Record()
        {
            Console.WriteLine("PlayRecord");
        }
        public void PauseRec()
        {
            Console.WriteLine("PauseRecord");
        }
        public void StopRec()
        {
            Console.WriteLine("StopRecord");
        }
        public void GetWrite()
        {
            Player player = new Player();
            player.Play();
            player.Pause();
            player.Stop();
            player.Record();
            player.PauseRec();
            player.StopRec();
        }
    }
}
