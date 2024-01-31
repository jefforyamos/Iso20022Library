﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxIdentificationNumberType1Code.  ISO2002 ID# _gK6fQAhJEeSUPbC7DbLJpQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of tax identification number.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gK6fQAhJEeSUPbC7DbLJpQ")]
[Description(@"Specifies the type of tax identification number.")]
[DerivedFrom(typeof(TaxIdentificationNumberTypeCode))]
public enum TaxIdentificationNumberType1Code
{
    /// <summary>
    /// Global intermediary tax identification number.
    /// Encoded/decoded by serializers as "GIIN".
    /// </summary>
    [EnumMember(Value = "GIIN")]
    [IsoId("_i_F3EQhJEeSUPbC7DbLJpQ")]
    [Description(@"Global intermediary tax identification number.")]
    GlobalIntermediaryIdentificationNumber = TaxIdentificationNumberTypeCode.GlobalIntermediaryIdentificationNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax identification number.
    /// Encoded/decoded by serializers as "GTIN".
    /// </summary>
    [EnumMember(Value = "GTIN")]
    [IsoId("_jIUEgQhJEeSUPbC7DbLJpQ")]
    [Description(@"Tax identification number.")]
    TaxIdentificationNumber = TaxIdentificationNumberTypeCode.TaxIdentificationNumber, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxIdentificationNumberType1CodeMetadataExtensions
{
    private static readonly TaxIdentificationNumberType1CodeDropdownSource _dropdownSource = new TaxIdentificationNumberType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxIdentificationNumberType1CodeDropdownRow GetMetadata(this TaxIdentificationNumberType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


