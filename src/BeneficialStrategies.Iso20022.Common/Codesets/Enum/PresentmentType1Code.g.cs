﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PresentmentType1Code.  ISO2002 ID# _pTnR0EWeEempSe_3C1a9EQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies which elements types must be presented in an e-invoice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pTnR0EWeEempSe_3C1a9EQ")]
[Description(@"Specifies which elements types must be presented in an e-invoice.")]
[DerivedFrom(typeof(PresentmentTypeCode))]
public enum PresentmentType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Full".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_rJ0lgUWeEempSe_3C1a9EQ")]
    [Description(@"??")]
    Full,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "RequiredPaymentData".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_rPjaEUWeEempSe_3C1a9EQ")]
    [Description(@"??")]
    RequiredPaymentData,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PresentmentType1CodeMetadataExtensions
{
    private static readonly PresentmentType1CodeDropdownSource _dropdownSource = new PresentmentType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPresentmentType1CodeDropdownRow GetMetadata(this PresentmentType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

