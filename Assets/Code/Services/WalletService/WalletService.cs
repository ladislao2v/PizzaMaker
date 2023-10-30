using System;
using Code.Services.SaveLoadDataService;
using Code.Services.SaveLoadDataService.Data;

namespace Code.Services.WalletService
{
    public class WalletService : IWalletService, ILoadable, ISavable
    {
        private int _value;

        public int Value => _value;
        
        public event Action<int> ValueChanged;

        public void Add(int value)
        {
            if (value < 0)
                throw new ArgumentException(nameof(_value));

            _value += value;
            
            ValueChanged?.Invoke(_value);
        }

        public void Spend(int value)
        {
            if (value < 0 || value > _value)
                throw new ArgumentException(nameof(_value));

            _value -= value;
            
            ValueChanged?.Invoke(_value);
        }

        public void LoadData(ISaveLoadDataService saveLoadDataService) => 
            _value = saveLoadDataService.Load<MoneyData>().Money;

        public void SaveData(ISaveLoadDataService saveLoadDataService) => 
            saveLoadDataService.Save<MoneyData>(new MoneyData(){ Money = _value });
    }
}