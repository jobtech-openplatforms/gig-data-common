namespace Jobtech.OpenPlatforms.GigDataCommon.Library
{
    
    public enum PlatformAchievementType
    {
        QualificationAssessment,
        Badge
    }

    public enum PlatformConnectionState
    {
        AwaitingOAuthAuthentication,
        AwaitingEmailVerification,
        Connected,
        Synced,
        Removed
    }

    
    public enum NotificationReason
    {
        DataUpdate,
        ConnectionDeleted
    }
}
