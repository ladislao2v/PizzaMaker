using System;
using TMPro;

namespace Code.Services.WalletService
{
    public interface IWalletService
    {
        int Value { get; }
        event Action<int> ValueChanged;
        
        void Add(int value);
        void Spend(int value);
    }
}