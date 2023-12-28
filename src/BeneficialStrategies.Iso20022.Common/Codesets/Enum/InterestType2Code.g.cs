﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InterestType2Code.  ISO2002 ID# __215cNojEeC60axPepSq7g_96023160.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates if the deal price is excluding or including the accrued interest.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__215cNojEeC60axPepSq7g_96023160")]
[Description(@"Indicates if the deal price is excluding or including the accrued interest.")]
[DerivedFrom(typeof(InterestTypeCode))]
public enum InterestType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CumInterest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__215cdojEeC60axPepSq7g_717130324")]
    [Description(@"??")]
    CumInterest,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExInterest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__215ctojEeC60axPepSq7g_1303077350")]
    [Description(@"??")]
    ExInterest,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InterestType2CodeMetadataExtensions
{
    private static readonly InterestType2CodeDropdownSource _dropdownSource = new InterestType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInterestType2CodeDropdownRow GetMetadata(this InterestType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

