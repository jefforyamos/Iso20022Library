﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesQuantity1Code.  ISO2002 ID# _VCCygDFxEeGKkIZzgd38VA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// TSE/JASDEC codes for planned, maximum and minimum of shares to be purchased.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VCCygDFxEeGKkIZzgd38VA")]
[Description(@"TSE/JASDEC codes for planned, maximum and minimum of shares to be purchased.")]
[DerivedFrom(typeof(SecuritiesQuantityTypeCode))]
public enum SecuritiesQuantity1Code
{
    /// <summary>
    /// No Maximum / Minimum number provided.
    /// Encoded/decoded by serializers as "SQNO".
    /// </summary>
    [EnumMember(Value = "SQNO")]
    [IsoId("_V_Is5jFxEeGKkIZzgd38VA")]
    [Description(@"No Maximum / Minimum number provided.")]
    No = SecuritiesQuantityTypeCode.No, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum / Minimum number is unknown or not decided.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_WDAgRjFxEeGKkIZzgd38VA")]
    [Description(@"Maximum / Minimum number is unknown or not decided.")]
    Unknown = SecuritiesQuantityTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum / Minimum number provided.
    /// Encoded/decoded by serializers as "SQYS".
    /// </summary>
    [EnumMember(Value = "SQYS")]
    [IsoId("_WJ3WNjFxEeGKkIZzgd38VA")]
    [Description(@"Maximum / Minimum number provided.")]
    Yes = SecuritiesQuantityTypeCode.Yes, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesQuantity1CodeMetadataExtensions
{
    private static readonly SecuritiesQuantity1CodeDropdownSource _dropdownSource = new SecuritiesQuantity1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesQuantity1CodeDropdownRow GetMetadata(this SecuritiesQuantity1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


