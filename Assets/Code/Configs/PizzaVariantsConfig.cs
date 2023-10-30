using System.Collections.Generic;
using Code.Views.Pizza;
using UnityEngine;

namespace Code.Configs
{
    public class PizzaVariantsConfig : MonoBehaviour
    {
        [SerializeField] private List<PizzaView> _pizzaViews;

        public PizzaView[] PizzaViews => _pizzaViews.ToArray();
    }
}