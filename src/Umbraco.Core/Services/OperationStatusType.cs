namespace Umbraco.Core.Services
{
    /// <summary>
    /// A status type of the result of saving an item
    /// </summary>
    /// <remarks>
    /// Anything less than 10 = Success!
    /// </remarks>
    public enum OperationStatusType
    {
        /// <summary>
        /// The saving was successful.
        /// </summary>
        Success = 0,
        
        /// <summary>
        /// The saving has been cancelled by a 3rd party add-in
        /// </summary>
        FailedCancelledByEvent = 14,

        /// <summary>
        /// Failed, an exception was thrown/handled
        /// </summary>
        FailedExceptionThrown = 15,
        
        /// <summary>
        /// When no operation is executed because it was not needed (i.e. deleting an item that doesn't exist)
        /// </summary>
        NoOperation = 100,

        //TODO: In the future, we might need to add more operations statuses, potentially like 'FailedByPermissions', etc...
    }
}