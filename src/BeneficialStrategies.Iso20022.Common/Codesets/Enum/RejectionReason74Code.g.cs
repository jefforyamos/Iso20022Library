﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RejectionReason74Code.  ISO2002 ID# _5KNFmCtWEeyhipY4f42fZQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Unrecognised or invalid depository.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5KNFmCtWEeyhipY4f42fZQ")]
[Description(@"Unrecognised or invalid depository.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason74Code
{
    /// <summary>
    /// Unrecognised or invalid message sender's safekeeping account.
    /// Encoded/decoded by serializers as "SafekeepingAccountRejection".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_7t3DMStYEeyF-PUIGuhxvA")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection,
    
    /// <summary>
    /// Transaction/instruction received after the account servicer's specified deadline.
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_7t3DMytYEeyF-PUIGuhxvA")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_7t3DNStYEeyF-PUIGuhxvA")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// Instruction could not be found.
    /// Encoded/decoded by serializers as "NotFoundRejection".
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_7t3DNytYEeyF-PUIGuhxvA")]
    [Description(@"Instruction could not be found.")]
    NotFoundRejection,
    
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as "ReferenceRejection".
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_7t3DOStYEeyF-PUIGuhxvA")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    ReferenceRejection,
    
    /// <summary>
    /// More than one instruction match the criteria.
    /// Encoded/decoded by serializers as "NoMatch".
    /// </summary>
    [EnumMember(Value = "NRGM")]
    [IsoId("_7t3DOytYEeyF-PUIGuhxvA")]
    [Description(@"More than one instruction match the criteria.")]
    NoMatch,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_7t3DPStYEeyF-PUIGuhxvA")]
    [Description(@"Other. See Narrative.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RejectionReason74CodeMetadataExtensions
{
    private static readonly RejectionReason74CodeDropdownSource _dropdownSource = new RejectionReason74CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRejectionReason74CodeDropdownRow GetMetadata(this RejectionReason74Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


