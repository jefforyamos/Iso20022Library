﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesQuantityTypeCode.  ISO2002 ID# _Bj5NMzFwEeGKkIZzgd38VA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// TSE/JASDEC codes for planned, maximum and minimum of shares to be purchased.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Bj5NMzFwEeGKkIZzgd38VA")]
[Description(@"TSE/JASDEC codes for planned, maximum and minimum of shares to be purchased.")]
[Derivations(typeof(SecuritiesQuantity1Code),typeof(SecuritiesQuantity2Code))]
// External derivations that should be provided by the proper interface are: 
public enum SecuritiesQuantityTypeCode
{
    /// <summary>
    /// No Maximum / Minimum number provided.
    /// Encoded/decoded by serializers as "SQNO".
    /// </summary>
    [EnumMember(Value = "SQNO")]
    [IsoId("_QXSwEDFwEeGKkIZzgd38VA")]
    [Description(@"No Maximum / Minimum number provided.")]
    No,
    
    /// <summary>
    /// Maximum / Minimum number provided.
    /// Encoded/decoded by serializers as "SQYS".
    /// </summary>
    [EnumMember(Value = "SQYS")]
    [IsoId("_3HRA0DFwEeGKkIZzgd38VA")]
    [Description(@"Maximum / Minimum number provided.")]
    Yes,
    
    /// <summary>
    /// Maximum / Minimum number is unknown or not decided.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_AQa9sDFxEeGKkIZzgd38VA")]
    [Description(@"Maximum / Minimum number is unknown or not decided.")]
    Unknown,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesQuantityTypeCodeMetadataExtensions
{
    private static readonly SecuritiesQuantityTypeCodeDropdownSource _dropdownSource = new SecuritiesQuantityTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesQuantityTypeCodeDropdownRow GetMetadata(this SecuritiesQuantityTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


