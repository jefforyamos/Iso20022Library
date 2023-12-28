﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason27Code.  ISO2002 ID# _BhhR0P4vEeClUvPNHKL9Zw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BhhR0P4vEeClUvPNHKL9Zw")]
[Description(@"Specifies the reason why the instruction/cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV2Code))]
public enum RejectionReason27Code
{
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_BhhR1v4vEeClUvPNHKL9Zw")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_BhhR2v4vEeClUvPNHKL9Zw")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SafekeepingAccountRejection".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_BhhR3v4vEeClUvPNHKL9Zw")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection,
    
    /// <summary>
    /// More than one instruction match the criteria.
    /// Encoded/decoded by serializers as "NoMatch".
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_BhhR4v4vEeClUvPNHKL9Zw")]
    [Description(@"More than one instruction match the criteria.")]
    NoMatch,
    
    /// <summary>
    /// Instruction could not be found.
    /// Encoded/decoded by serializers as "NotFoundRejection".
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_BhhR5v4vEeClUvPNHKL9Zw")]
    [Description(@"Instruction could not be found.")]
    NotFoundRejection,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_BhhR6v4vEeClUvPNHKL9Zw")]
    [Description(@"Other. See Narrative.")]
    Other,
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as "ReferenceRejection".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_BhhR7v4vEeClUvPNHKL9Zw")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    ReferenceRejection,
    
    /// <summary>
    /// Invalid or unrecognized modification request.
    /// Encoded/decoded by serializers as "InvalidModificationRequest".
    /// </summary>
    [EnumMember(Value = "INVM")]
    [IsoId("_xwRr_v8FEeCCq-oUcJbFqw")]
    [Description(@"Invalid or unrecognized modification request.")]
    InvalidModificationRequest,
    
    /// <summary>
    /// Invalid or unrecognized link.
    /// Encoded/decoded by serializers as "InvalidLink".
    /// </summary>
    [EnumMember(Value = "INVL")]
    [IsoId("_yNLqbv8FEeCCq-oUcJbFqw")]
    [Description(@"Invalid or unrecognized link.")]
    InvalidLink,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason27CodeMetadataExtensions
{
    private static readonly RejectionReason27CodeDropdownSource _dropdownSource = new RejectionReason27CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason27CodeDropdownRow GetMetadata(this RejectionReason27Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


