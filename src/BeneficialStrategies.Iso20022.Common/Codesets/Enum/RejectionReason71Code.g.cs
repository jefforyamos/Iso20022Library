﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason71Code.  ISO2002 ID# _dEaVCitVEeyhipY4f42fZQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dEaVCitVEeyhipY4f42fZQ")]
[Description(@"Specifies the reason why the instruction/cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason71Code
{
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "ADEA".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_98T3wStYEeyF-PUIGuhxvA")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonV3Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "LATE".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_98T3wytYEeyF-PUIGuhxvA")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SAFE".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_98T3xStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV3Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// More than one instruction match the criteria.
    /// Encoded/decoded by serializers as "NRGM".
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_98T3xytYEeyF-PUIGuhxvA")]
    [Description(@"More than one instruction match the criteria.")]
    NoMatch = RejectionReasonV3Code.NoMatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction could not be found.
    /// Encoded/decoded by serializers as "NRGN".
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_98T3yStYEeyF-PUIGuhxvA")]
    [Description(@"Instruction could not be found.")]
    NotFoundRejection = RejectionReasonV3Code.NotFoundRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_98T3yytYEeyF-PUIGuhxvA")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as "REFE".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_98T3zStYEeyF-PUIGuhxvA")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    ReferenceRejection = RejectionReasonV3Code.ReferenceRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid or unrecognized modification request.
    /// Encoded/decoded by serializers as "INVM".
    /// </summary>
    [EnumMember(Value = "INVM")]
    [IsoId("_98T3zytYEeyF-PUIGuhxvA")]
    [Description(@"Invalid or unrecognized modification request.")]
    InvalidModificationRequest = RejectionReasonV3Code.InvalidModificationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid or unrecognized link.
    /// Encoded/decoded by serializers as "INVL".
    /// </summary>
    [EnumMember(Value = "INVL")]
    [IsoId("_98T30StYEeyF-PUIGuhxvA")]
    [Description(@"Invalid or unrecognized link.")]
    InvalidLink = RejectionReasonV3Code.InvalidLink, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason71CodeMetadataExtensions
{
    private static readonly RejectionReason71CodeDropdownSource _dropdownSource = new RejectionReason71CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason71CodeDropdownRow GetMetadata(this RejectionReason71Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


