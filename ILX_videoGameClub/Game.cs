using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILX_videoGameClub
{
    
    public class Game
     {  
        private sbyte _gameId;
        public sbyte gameId
        {
            get
            {
                return _gameId;
            }
            set { 
                
                if (value <= 0) 
                {
                    Console.WriteLine("Game id must contain 4 digits");
                }
                else
                {
                    _gameId = value;    
                }
                    }
            
        
        }
        public string platform { get; set; }
        public string gameName { get; set; }
        public sbyte quantity { get; set; }
        public bool isBorrowed { get; set; }

    

     }
    
}


class Aluno
{
    private int matricula;
    public int Matricula
    {
        get
        {
            return matricula;
        }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("The number entered has to be positive.");
                
            }
            else
            {
                matricula = value;
            }
        }
    }
    public string Nome { get; set; }
    public string Email { get; set; }
    public bool Status { get; set; }
    public int TipoCurso { get; set; }
}