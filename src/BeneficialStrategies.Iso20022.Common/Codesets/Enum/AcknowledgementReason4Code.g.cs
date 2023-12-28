﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AcknowledgementReason4Code.  ISO2002 ID# _bpPSANp-Ed-ak6NoX_4Aeg_-1257492124.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bpPSANp-Ed-ak6NoX_4Aeg_-1257492124")]
[Description(@"Specifies additional information about the processed instruction.")]
[DerivedFrom(typeof(AcknowledgementReasonCode))]
public enum AcknowledgementReason4Code
{
    /// <summary>
    /// Received after the account servicer's deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_bpPSAdp-Ed-ak6NoX_4Aeg_-966580559")]
    [Description(@"Received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_bpPSAtp-Ed-ak6NoX_4Aeg_-925024563")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed,
    
    /// <summary>
    /// Instruction was not straight through processing and had to be processed manually.
    /// Encoded/decoded by serializers as "NotStraightThroughProcessing".
    /// </summary>
    [EnumMember(Value = "NSTP")]
    [IsoId("_bpPSA9p-Ed-ak6NoX_4Aeg_-856682877")]
    [Description(@"Instruction was not straight through processing and had to be processed manually.")]
    NotStraightThroughProcessing,
    
    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bpPSBNp-Ed-ak6NoX_4Aeg_1167272842")]
    [Description(@"Other. See Narrative.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AcknowledgementReason4CodeMetadataExtensions
{
    private static readonly AcknowledgementReason4CodeDropdownSource _dropdownSource = new AcknowledgementReason4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAcknowledgementReason4CodeDropdownRow GetMetadata(this AcknowledgementReason4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


