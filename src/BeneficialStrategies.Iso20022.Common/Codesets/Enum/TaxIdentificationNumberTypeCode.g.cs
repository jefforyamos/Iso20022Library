﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxIdentificationNumberTypeCode.  ISO2002 ID# _RXCbQQhJEeSUPbC7DbLJpQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of tax identification number.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RXCbQQhJEeSUPbC7DbLJpQ")]
[Description(@"Specifies the type of tax identification number.")]
public enum TaxIdentificationNumberTypeCode
{
    /// <summary>
    /// Tax identification number.
    /// Encoded/decoded by serializers as "GTIN".
    /// </summary>
    [EnumMember(Value = "GTIN")]
    [IsoId("_WVR24AhJEeSUPbC7DbLJpQ")]
    [Description(@"Tax identification number.")]
    TaxIdentificationNumber,
    
    /// <summary>
    /// Global intermediary tax identification number.
    /// Encoded/decoded by serializers as "GIIN".
    /// </summary>
    [EnumMember(Value = "GIIN")]
    [IsoId("_abk94AhJEeSUPbC7DbLJpQ")]
    [Description(@"Global intermediary tax identification number.")]
    GlobalIntermediaryIdentificationNumber,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxIdentificationNumberTypeCodeMetadataExtensions
{
    private static readonly TaxIdentificationNumberTypeCodeDropdownSource _dropdownSource = new TaxIdentificationNumberTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxIdentificationNumberTypeCodeDropdownRow GetMetadata(this TaxIdentificationNumberTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


