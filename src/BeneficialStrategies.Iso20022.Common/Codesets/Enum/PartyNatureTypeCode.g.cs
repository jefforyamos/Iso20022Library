﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartyNatureTypeCode.  ISO2002 ID# _ei1oQc2IEeS6sY79p-9Zxw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of a counterparty.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ei1oQc2IEeS6sY79p-9Zxw")]
[Description(@"Specifies the nature of a counterparty.")]
[Derivations(typeof(PartyNatureType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum PartyNatureTypeCode
{
    /// <summary>
    /// Issuer is a financial institution.
    /// Encoded/decoded by serializers as "FIIN".
    /// </summary>
    [EnumMember(Value = "FIIN")]
    [IsoId("_gkuAcM2IEeS6sY79p-9Zxw")]
    [Description(@"Issuer is a financial institution.")]
    FinancialInstitution,
    
    /// <summary>
    /// Issuer is a non-financial institution.
    /// Encoded/decoded by serializers as "NFIN".
    /// </summary>
    [EnumMember(Value = "NFIN")]
    [IsoId("_oiP3sM2IEeS6sY79p-9Zxw")]
    [Description(@"Issuer is a non-financial institution.")]
    NonFinancialInstitution,
    
    /// <summary>
    /// Issuer is a central counterparty.
    /// Encoded/decoded by serializers as "CCPS".
    /// </summary>
    [EnumMember(Value = "CCPS")]
    [IsoId("_X_ZnsB3dEeWTa7N6lo4ufA")]
    [Description(@"Issuer is a central counterparty.")]
    CentralCounterparty,
    
    /// <summary>
    /// Other type of issuer.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bZM1EB3dEeWTa7N6lo4ufA")]
    [Description(@"Other type of issuer.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartyNatureTypeCodeMetadataExtensions
{
    private static readonly PartyNatureTypeCodeDropdownSource _dropdownSource = new PartyNatureTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartyNatureTypeCodeDropdownRow GetMetadata(this PartyNatureTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


