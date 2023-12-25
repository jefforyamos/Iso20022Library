﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesQuantity1Code.  ISO2002 ID# _VCCygDFxEeGKkIZzgd38VA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// TSE/JASDEC codes for planned, maximum and minimum of shares to be purchased.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VCCygDFxEeGKkIZzgd38VA")]
[Description(@"TSE/JASDEC codes for planned, maximum and minimum of shares to be purchased.")]
public enum SecuritiesQuantity1Code
{
    /// <summary>
    /// ??
    /// </summary>
    [EnumMember(Value = "SQNO")]
    [IsoId("_V_Is5jFxEeGKkIZzgd38VA")]
    [Description(@"??")]
    SQNO,
    
    /// <summary>
    /// ??
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_WDAgRjFxEeGKkIZzgd38VA")]
    [Description(@"??")]
    UKWN,
    
    /// <summary>
    /// ??
    /// </summary>
    [EnumMember(Value = "SQYS")]
    [IsoId("_WJ3WNjFxEeGKkIZzgd38VA")]
    [Description(@"??")]
    SQYS,
    
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


