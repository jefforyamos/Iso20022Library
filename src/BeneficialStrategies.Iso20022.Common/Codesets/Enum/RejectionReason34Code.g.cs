﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason34Code.  ISO2002 ID# _jWLNs-5NEeCisYr99QEiWA_376105983.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jWLNs-5NEeCisYr99QEiWA_376105983")]
[Description(@"Specifies the reason why the instruction/cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV2Code))]
public enum RejectionReason34Code
{
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_jWLNtO5NEeCisYr99QEiWA_440385589")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonV2Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_jWUXoO5NEeCisYr99QEiWA_-620966370")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV2Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_jWUXoe5NEeCisYr99QEiWA_-442847698")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount = RejectionReasonV2Code.CashAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// More than one instruction match the criteria.
    /// Encoded/decoded by serializers as "NRGM".
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_jWUXou5NEeCisYr99QEiWA_-734805436")]
    [Description(@"More than one instruction match the criteria.")]
    NoMatch = RejectionReasonV2Code.NoMatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction could not be found.
    /// Encoded/decoded by serializers as "NRGN".
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_jWUXo-5NEeCisYr99QEiWA_-556686764")]
    [Description(@"Instruction could not be found.")]
    NotFoundRejection = RejectionReasonV2Code.NotFoundRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_jWUXpO5NEeCisYr99QEiWA_-1618038723")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV2Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as "REFE".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_jWeIoO5NEeCisYr99QEiWA_-1731877789")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    ReferenceRejection = RejectionReasonV2Code.ReferenceRejection, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason34CodeMetadataExtensions
{
    private static readonly RejectionReason34CodeDropdownSource _dropdownSource = new RejectionReason34CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason34CodeDropdownRow GetMetadata(this RejectionReason34Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


