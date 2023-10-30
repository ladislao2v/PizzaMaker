using System.Collections;
using UnityEngine;

namespace Code.Services.PizzaSpawnerService
{
    public class PizzaSpawnerService : IPizzaSpawnerService
    {
        private readonly ICoroutineRunner _coroutineRunner;
        private Coroutine _currentCoroutine; 

        public PizzaSpawnerService(ICoroutineRunner coroutineRunner)
        {
            _coroutineRunner = coroutineRunner;
        }

        public void Start()
        {
            _currentCoroutine = _coroutineRunner.StartCoroutine(GeneratePizza());
        }

        public void Stop()
        {
            _coroutineRunner.StopCoroutine(_currentCoroutine);
        }

        private IEnumerator GeneratePizza()
        {
            throw new System.NotImplementedException();
        }
    }
}