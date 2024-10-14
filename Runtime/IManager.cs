using System;

namespace LF.Interfaces.Runtime
{
    public interface IManager
    {
        // Initialization method
        void AwakeManager();
        void StartManager();
        
        void UpdateManager();
        void FixedUpdateManager();
        void LateUpdateManager();
        
        void OnEnableManager();
        void OnDisableManager();
        void OnDestroyManager();

        // Shutdown method
        void ShutdownManager();

        // Property to check if initialized
        bool IsInitialized { get; }
        // Event for initialization completion
        event Action OnInitializationComplete;

        // Optional: Add other common method signatures or properties
    }
}