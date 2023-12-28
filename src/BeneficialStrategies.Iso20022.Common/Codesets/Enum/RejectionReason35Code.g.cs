﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason35Code.  ISO2002 ID# _jWeIoe5NEeCisYr99QEiWA_668020019.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jWeIoe5NEeCisYr99QEiWA_668020019")]
[Description(@"Specifies the reason why the instruction/cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV2Code))]
public enum RejectionReason35Code
{
    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as "CashAccount".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_jWeIou5NEeCisYr99QEiWA_732299625")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount,
    
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_jWeIo-5NEeCisYr99QEiWA_-329052334")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as "ReferenceRejection".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_jWeIpO5NEeCisYr99QEiWA_-150933662")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    ReferenceRejection,
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_jWnSkO5NEeCisYr99QEiWA_-442891400")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// Unrecognised or invalid settlement date.
    /// Encoded/decoded by serializers as "SettlementDateRejection".
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_jWnSke5NEeCisYr99QEiWA_-264772728")]
    [Description(@"Unrecognised or invalid settlement date.")]
    SettlementDateRejection,
    
    /// <summary>
    /// Instruction could not be found.
    /// Encoded/decoded by serializers as "NotFoundRejection".
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_jWnSku5NEeCisYr99QEiWA_1213359397")]
    [Description(@"Instruction could not be found.")]
    NotFoundRejection,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_jWnSk-5NEeCisYr99QEiWA_-1326124687")]
    [Description(@"Other. See Narrative.")]
    Other,
    
    /// <summary>
    /// Invalid or unrecognized modification request.
    /// Encoded/decoded by serializers as "InvalidModificationRequest".
    /// </summary>
    [EnumMember(Value = "INVM")]
    [IsoId("_AzkQYnglEeGqN5NokjUPnw_-1651616515")]
    [Description(@"Invalid or unrecognized modification request.")]
    InvalidModificationRequest,
    
    /// <summary>
    /// Invalid or unrecognized link.
    /// Encoded/decoded by serializers as "InvalidLink".
    /// </summary>
    [EnumMember(Value = "INVL")]
    [IsoId("_AzkQY3glEeGqN5NokjUPnw_-2048316852")]
    [Description(@"Invalid or unrecognized link.")]
    InvalidLink,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason35CodeMetadataExtensions
{
    private static readonly RejectionReason35CodeDropdownSource _dropdownSource = new RejectionReason35CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason35CodeDropdownRow GetMetadata(this RejectionReason35Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


