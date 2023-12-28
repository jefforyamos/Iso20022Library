﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartyNatureType1Code.  ISO2002 ID# _eGrH8B3dEeWTa7N6lo4ufA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of a counterparty.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eGrH8B3dEeWTa7N6lo4ufA")]
[Description(@"Specifies the nature of a counterparty.")]
[DerivedFrom(typeof(PartyNatureTypeCode))]
public enum PartyNatureType1Code
{
    /// <summary>
    /// Other type of issuer.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ge0rER3dEeWTa7N6lo4ufA")]
    [Description(@"Other type of issuer.")]
    Other,
    
    /// <summary>
    /// Issuer is a non-financial institution.
    /// Encoded/decoded by serializers as "NonFinancialInstitution".
    /// </summary>
    [EnumMember(Value = "NFIN")]
    [IsoId("_gts0kR3dEeWTa7N6lo4ufA")]
    [Description(@"Issuer is a non-financial institution.")]
    NonFinancialInstitution,
    
    /// <summary>
    /// Issuer is a financial institution.
    /// Encoded/decoded by serializers as "FinancialInstitution".
    /// </summary>
    [EnumMember(Value = "FIIN")]
    [IsoId("_gyBT4R3dEeWTa7N6lo4ufA")]
    [Description(@"Issuer is a financial institution.")]
    FinancialInstitution,
    
    /// <summary>
    /// Issuer is a central counterparty.
    /// Encoded/decoded by serializers as "CentralCounterparty".
    /// </summary>
    [EnumMember(Value = "CCPS")]
    [IsoId("_hBMYUR3dEeWTa7N6lo4ufA")]
    [Description(@"Issuer is a central counterparty.")]
    CentralCounterparty,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartyNatureType1CodeMetadataExtensions
{
    private static readonly PartyNatureType1CodeDropdownSource _dropdownSource = new PartyNatureType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartyNatureType1CodeDropdownRow GetMetadata(this PartyNatureType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


