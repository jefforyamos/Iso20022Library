﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfAmount21Code.  ISO2002 ID# _EG1A4aH_EeuiuNcvKhXmNQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type or class of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EG1A4aH_EeuiuNcvKhXmNQ")]
[Description(@"Type or class of amount.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
public enum TypeOfAmount21Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InterchangeFee".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EL_NsaH_EeuiuNcvKhXmNQ")]
    [Description(@"??")]
    InterchangeFee,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ProcessingFees".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EL_Ns6H_EeuiuNcvKhXmNQ")]
    [Description(@"??")]
    ProcessingFees,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EL_NtaH_EeuiuNcvKhXmNQ")]
    [Description(@"??")]
    OtherNational,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EL_Nt6H_EeuiuNcvKhXmNQ")]
    [Description(@"??")]
    OtherPrivate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "InternationalServiceAssessmentFees".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_EL_NuaH_EeuiuNcvKhXmNQ")]
    [Description(@"??")]
    InternationalServiceAssessmentFees,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CashBackInterchangeFee".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UQGKgaH_EeuiuNcvKhXmNQ")]
    [Description(@"??")]
    CashBackInterchangeFee,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MaximumInterchangeFee".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WF3ZUaH_EeuiuNcvKhXmNQ")]
    [Description(@"??")]
    MaximumInterchangeFee,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MinimumInterchangeFee".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WpWg4aH_EeuiuNcvKhXmNQ")]
    [Description(@"??")]
    MinimumInterchangeFee,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfAmount21CodeMetadataExtensions
{
    private static readonly TypeOfAmount21CodeDropdownSource _dropdownSource = new TypeOfAmount21CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfAmount21CodeDropdownRow GetMetadata(this TypeOfAmount21Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


