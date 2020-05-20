using System.Collections.Generic;

namespace LudoParty.DataModel.Models
{
    public class Square
    {
        private Dictionary<byte, Colors> _tokensInSquare = new Dictionary<byte, Colors>();

        public bool IsHome { get; set; }
        public bool IsStar { get; set; }
        public bool IsEmpty { get; set; }
        public bool IsValid { get; set; }

        public Dictionary<byte, Colors> TokensInSquare
        {
            get => _tokensInSquare;
            set =>_tokensInSquare = value;
        }
    }
}