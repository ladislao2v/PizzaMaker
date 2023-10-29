using UnityEngine;
using Zenject;

namespace Code.Installers.LocalInstallers
{
    public class AudioListenerInstaller : MonoInstaller
    {
        [SerializeField] private AudioListener _audioListener;
        
        public override void InstallBindings()
        {
            BindAudioListener();
        }

        private void BindAudioListener() =>
            Container
                .Bind<AudioListener>()
                .FromInstance(_audioListener)
                .AsSingle();
    }
}
