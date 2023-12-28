﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EventWorkflowStatusCode.  ISO2002 ID# _1v-3kzL3EeKU9IrkkToqcw_-1586819968.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the workflow status of the announcement record based on validation procedure.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1v-3kzL3EeKU9IrkkToqcw_-1586819968")]
[Description(@"Specifies the workflow status of the announcement record based on validation procedure.")]
public enum EventWorkflowStatusCode
{
    /// <summary>
    /// All of the required data has been populated. Any conflicting data has been resolved. Either all information was in agreement (STP) or if manual validation was necessary authorised review and changes/updates were performed.
    /// Encoded/decoded by serializers as "WSAP".
    /// </summary>
    [EnumMember(Value = "WSAP")]
    [IsoId("_1v-3lDL3EeKU9IrkkToqcw_-2123628145")]
    [Description(@"All of the required data has been populated. Any conflicting data has been resolved. Either all information was in agreement (STP) or if manual validation was necessary authorised review and changes/updates were performed.")]
    Approved,
    
    /// <summary>
    /// Announcement has been confirmed but not all of the required data is available. Event was validated or specific STP criteria was met, however data is still pending confirmation of the event.
    /// Encoded/decoded by serializers as "WSCA".
    /// </summary>
    [EnumMember(Value = "WSCA")]
    [IsoId("_1v-3lTL3EeKU9IrkkToqcw_1956674844")]
    [Description(@"Announcement has been confirmed but not all of the required data is available. Event was validated or specific STP criteria was met, however data is still pending confirmation of the event.")]
    ConditionallyApproved,
    
    /// <summary>
    /// Validation has determined event is being cancelled by the issuer/offeror. Either all information was in agreement (STP) or if manual validation was necessary authorised review and changes/updates were performed.
    /// Encoded/decoded by serializers as "WSCN".
    /// </summary>
    [EnumMember(Value = "WSCN")]
    [IsoId("_1v-3ljL3EeKU9IrkkToqcw_-1913359731")]
    [Description(@"Validation has determined event is being cancelled by the issuer/offeror. Either all information was in agreement (STP) or if manual validation was necessary authorised review and changes/updates were performed.")]
    Cancelled,
    
    /// <summary>
    /// Two or more sources disagree on one or more data elements.
    /// Encoded/decoded by serializers as "WSCT".
    /// </summary>
    [EnumMember(Value = "WSCT")]
    [IsoId("_1wIBgDL3EeKU9IrkkToqcw_-1997911504")]
    [Description(@"Two or more sources disagree on one or more data elements.")]
    InConflict,
    
    /// <summary>
    /// Announcement record has been deleted/ removed as an invalid record.
    /// Encoded/decoded by serializers as "WSDE".
    /// </summary>
    [EnumMember(Value = "WSDE")]
    [IsoId("_1wIBgTL3EeKU9IrkkToqcw_1401560978")]
    [Description(@"Announcement record has been deleted/ removed as an invalid record.")]
    Deleted,
    
    /// <summary>
    /// Required data is not available. Announcement record cannot be verified.
    /// Encoded/decoded by serializers as "WSIN".
    /// </summary>
    [EnumMember(Value = "WSIN")]
    [IsoId("_1wIBgjL3EeKU9IrkkToqcw_362757598")]
    [Description(@"Required data is not available. Announcement record cannot be verified.")]
    Incomplete,
    
    /// <summary>
    /// Announcement record is not supported by validation service.
    /// Encoded/decoded by serializers as "WSNS".
    /// </summary>
    [EnumMember(Value = "WSNS")]
    [IsoId("_1wIBgzL3EeKU9IrkkToqcw_2003828685")]
    [Description(@"Announcement record is not supported by validation service.")]
    NotSupported,
    
    /// <summary>
    /// Validation review was performed and event has been modified. Event is pending authorised approval.
    /// Encoded/decoded by serializers as "WSPA".
    /// </summary>
    [EnumMember(Value = "WSPA")]
    [IsoId("_1wIBhDL3EeKU9IrkkToqcw_1232628209")]
    [Description(@"Validation review was performed and event has been modified. Event is pending authorised approval.")]
    PendingApproval,
    
    /// <summary>
    /// Validation has determined event is being cancelled by the issuer/offeror. Pending authorisation.
    /// Encoded/decoded by serializers as "WSPC".
    /// </summary>
    [EnumMember(Value = "WSPC")]
    [IsoId("_1wIBhTL3EeKU9IrkkToqcw_274039315")]
    [Description(@"Validation has determined event is being cancelled by the issuer/offeror. Pending authorisation.")]
    PendingCancelled,
    
    /// <summary>
    /// Validation review has been performed and event has been modified. Announcement has been confirmed but not all of the required data is available. Even record is pending authorised approval.
    /// Encoded/decoded by serializers as "WSPN".
    /// </summary>
    [EnumMember(Value = "WSPN")]
    [IsoId("_1wIBhjL3EeKU9IrkkToqcw_1233818942")]
    [Description(@"Validation review has been performed and event has been modified. Announcement has been confirmed but not all of the required data is available. Even record is pending authorised approval.")]
    PendingConditionalApproval,
    
    /// <summary>
    /// Validation has determined the announcement record to be invalid. Pending authorisation.
    /// Encoded/decoded by serializers as "WSPD".
    /// </summary>
    [EnumMember(Value = "WSPD")]
    [IsoId("_1wRygDL3EeKU9IrkkToqcw_-1085956713")]
    [Description(@"Validation has determined the announcement record to be invalid. Pending authorisation.")]
    PendingDeleted,
    
    /// <summary>
    /// Validation has determined that the record is not supported. Pending authorisations.
    /// Encoded/decoded by serializers as "WSPS".
    /// </summary>
    [EnumMember(Value = "WSPS")]
    [IsoId("_1wRygTL3EeKU9IrkkToqcw_718899800")]
    [Description(@"Validation has determined that the record is not supported. Pending authorisations.")]
    PendingNotSupported,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EventWorkflowStatusCodeMetadataExtensions
{
    private static readonly EventWorkflowStatusCodeDropdownSource _dropdownSource = new EventWorkflowStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEventWorkflowStatusCodeDropdownRow GetMetadata(this EventWorkflowStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

