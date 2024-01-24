﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BeneficiaryType1Code.  ISO2002 ID# _NtVGAFNhEeijdq8ilaxyOA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of beneficiary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NtVGAFNhEeijdq8ilaxyOA")]
[Description(@"Specifies a type of beneficiary.")]
[DerivedFrom(typeof(BeneficiaryTypeCode))]
public enum BeneficiaryType1Code
{
    /// <summary>
    /// Beneficiary is a dependent.
    /// Encoded/decoded by serializers as "DEPE".
    /// </summary>
    [EnumMember(Value = "DEPE")]
    [IsoId("_Opuc0VNhEeijdq8ilaxyOA")]
    [Description(@"Beneficiary is a dependent.")]
    Dependent = BeneficiaryTypeCode.Dependent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Beneficiary is a nominee.
    /// Encoded/decoded by serializers as "NOMI".
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_OtcfMVNhEeijdq8ilaxyOA")]
    [Description(@"Beneficiary is a nominee.")]
    Nominee = BeneficiaryTypeCode.Nominee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Beneficiary is a successor.
    /// Encoded/decoded by serializers as "SUCC".
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_OxnNgVNhEeijdq8ilaxyOA")]
    [Description(@"Beneficiary is a successor.")]
    Successor = BeneficiaryTypeCode.Successor, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BeneficiaryType1CodeMetadataExtensions
{
    private static readonly BeneficiaryType1CodeDropdownSource _dropdownSource = new BeneficiaryType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBeneficiaryType1CodeDropdownRow GetMetadata(this BeneficiaryType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


