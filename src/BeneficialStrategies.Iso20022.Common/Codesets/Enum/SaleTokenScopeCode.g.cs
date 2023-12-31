﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SaleTokenScopeCode.  ISO2002 ID# _lucbANwsEeioifFt1dhnJA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Scope of the token that identifies  the payment mean of the customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lucbANwsEeioifFt1dhnJA")]
[Description(@"Scope of the token that identifies  the payment mean of the customer.")]
[Derivations(typeof(SaleTokenScope1Code))]
// External derivations that should be provided by the proper interface are: 
public enum SaleTokenScopeCode
{
    /// <summary>
    /// The token is generated to recognise  a customer during the lifetime of a transaction.
    /// Encoded/decoded by serializers as "SNGL".
    /// </summary>
    [EnumMember(Value = "SNGL")]
    [IsoId("_px_wANwsEeioifFt1dhnJA")]
    [Description(@"The token is generated to recognise  a customer during the lifetime of a transaction.")]
    SingleUse,
    
    /// <summary>
    /// The token is generated to recognise a customer for a longer period.
    /// Encoded/decoded by serializers as "MULT".
    /// </summary>
    [EnumMember(Value = "MULT")]
    [IsoId("_uLv-gNwsEeioifFt1dhnJA")]
    [Description(@"The token is generated to recognise a customer for a longer period.")]
    MultipleUse,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SaleTokenScopeCodeMetadataExtensions
{
    private static readonly SaleTokenScopeCodeDropdownSource _dropdownSource = new SaleTokenScopeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISaleTokenScopeCodeDropdownRow GetMetadata(this SaleTokenScopeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


