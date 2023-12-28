﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SaleTokenScope1Code.  ISO2002 ID# _ydFQ0NwsEeioifFt1dhnJA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Scope of the token that identifies the payment mean of the customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ydFQ0NwsEeioifFt1dhnJA")]
[Description(@"Scope of the token that identifies the payment mean of the customer.")]
[DerivedFrom(typeof(SaleTokenScopeCode))]
public enum SaleTokenScope1Code
{
    /// <summary>
    /// The token is generated to recognise a customer for a longer period.
    /// Encoded/decoded by serializers as "MultipleUse".
    /// </summary>
    [EnumMember(Value = "MULT")]
    [IsoId("_1z1xQdwsEeioifFt1dhnJA")]
    [Description(@"The token is generated to recognise a customer for a longer period.")]
    MultipleUse,
    
    /// <summary>
    /// The token is generated to recognise  a customer during the lifetime of a transaction.
    /// Encoded/decoded by serializers as "SingleUse".
    /// </summary>
    [EnumMember(Value = "SNGL")]
    [IsoId("_147FkdwsEeioifFt1dhnJA")]
    [Description(@"The token is generated to recognise  a customer during the lifetime of a transaction.")]
    SingleUse,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SaleTokenScope1CodeMetadataExtensions
{
    private static readonly SaleTokenScope1CodeDropdownSource _dropdownSource = new SaleTokenScope1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISaleTokenScope1CodeDropdownRow GetMetadata(this SaleTokenScope1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


