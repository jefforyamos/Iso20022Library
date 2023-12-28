﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BeneficiaryTypeCode.  ISO2002 ID# _8byFsFNgEeijdq8ilaxyOA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of beneficiary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8byFsFNgEeijdq8ilaxyOA")]
[Description(@"Specifies a type of beneficiary.")]
public enum BeneficiaryTypeCode
{
    /// <summary>
    /// Beneficiary is a dependent.
    /// Encoded/decoded by serializers as "DEPE".
    /// </summary>
    [EnumMember(Value = "DEPE")]
    [IsoId("__reU0FNgEeijdq8ilaxyOA")]
    [Description(@"Beneficiary is a dependent.")]
    Dependent,
    
    /// <summary>
    /// Beneficiary is a nominee.
    /// Encoded/decoded by serializers as "NOMI".
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_GzUhQFNhEeijdq8ilaxyOA")]
    [Description(@"Beneficiary is a nominee.")]
    Nominee,
    
    /// <summary>
    /// Beneficiary is a successor.
    /// Encoded/decoded by serializers as "SUCC".
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_JziJ8FNhEeijdq8ilaxyOA")]
    [Description(@"Beneficiary is a successor.")]
    Successor,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BeneficiaryTypeCodeMetadataExtensions
{
    private static readonly BeneficiaryTypeCodeDropdownSource _dropdownSource = new BeneficiaryTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBeneficiaryTypeCodeDropdownRow GetMetadata(this BeneficiaryTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

