using Code.Services.InputSystem;
using Zenject;

namespace Code.Installers.LocalInstallers
{
    public class InputServiceInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindInputService();
        }

        private void BindInputService() =>
            Container
                .BindInterfacesAndSelfTo<MouseInputService>()
                .AsSingle();
    }
}