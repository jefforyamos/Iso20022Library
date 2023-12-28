﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AcknowledgementReason6Code.  ISO2002 ID# _0mppcAlIEeGATtfOBToyew_753988061.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0mppcAlIEeGATtfOBToyew_753988061")]
[Description(@"Specifies additional information about the processed instruction.")]
[DerivedFrom(typeof(AcknowledgementReasonCode))]
public enum AcknowledgementReason6Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AccountServicerDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_0mppcQlIEeGATtfOBToyew_818267667")]
    [Description(@"??")]
    AccountServicerDeadlineMissed,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketPracticeRuleDiscrepency".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_0mppcglIEeGATtfOBToyew_-243084292")]
    [Description(@"??")]
    MarketPracticeRuleDiscrepency,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_0mppcwlIEeGATtfOBToyew_-64965620")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotStraightThroughProcessing".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_0mppdAlIEeGATtfOBToyew_-1062037973")]
    [Description(@"??")]
    NotStraightThroughProcessing,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketDeadlineMissed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_0mppdQlIEeGATtfOBToyew_-1175877039")]
    [Description(@"??")]
    MarketDeadlineMissed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AcknowledgementReason6CodeMetadataExtensions
{
    private static readonly AcknowledgementReason6CodeDropdownSource _dropdownSource = new AcknowledgementReason6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAcknowledgementReason6CodeDropdownRow GetMetadata(this AcknowledgementReason6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


