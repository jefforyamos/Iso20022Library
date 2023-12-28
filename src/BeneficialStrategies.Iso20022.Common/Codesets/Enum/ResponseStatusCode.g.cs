﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ResponseStatusCode.  ISO2002 ID# _Y94fANp-Ed-ak6NoX_4Aeg_1785427389.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the received collateral message (collateral claim, a collateral proposal or a proposal/request for collateral substitution) from a collateral management perspective.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y94fANp-Ed-ak6NoX_4Aeg_1785427389")]
[Description(@"Specifies the status of the received collateral message (collateral claim, a collateral proposal or a proposal/request for collateral substitution) from a collateral management perspective.")]
public enum ResponseStatusCode
{
    /// <summary>
    /// Part of the collateral is accepted, a part rejected.
    /// Encoded/decoded by serializers as "ACCP".
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_Y94fAdp-Ed-ak6NoX_4Aeg_-2007141387")]
    [Description(@"Part of the collateral is accepted, a part rejected.")]
    PartlyAccepted,
    
    /// <summary>
    /// Claim, substitution, proposal is fully accepted.
    /// Encoded/decoded by serializers as "ACCT".
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_Y94fAtp-Ed-ak6NoX_4Aeg_-1286794697")]
    [Description(@"Claim, substitution, proposal is fully accepted.")]
    Accepted,
    
    /// <summary>
    /// Claim, substitution, proposal is fully rejected.
    /// Encoded/decoded by serializers as "REJT".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_Y94fA9p-Ed-ak6NoX_4Aeg_-1200908229")]
    [Description(@"Claim, substitution, proposal is fully rejected.")]
    Rejected,
    
    /// <summary>
    /// Party A agrees with the return part of the substitution and accepts to wait for the proposal of the new collateral.
    /// Encoded/decoded by serializers as "SUBR".
    /// </summary>
    [EnumMember(Value = "SUBR")]
    [IsoId("_Y94fBNp-Ed-ak6NoX_4Aeg_-1161198752")]
    [Description(@"Party A agrees with the return part of the substitution and accepts to wait for the proposal of the new collateral.")]
    SubstitutionAccepted,
    
    /// <summary>
    /// Collateral giver instruction details are confirmed.
    /// Encoded/decoded by serializers as "CONF".
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_dS5_gcf0EemlRYW9CHJ8_Q")]
    [Description(@"Collateral giver instruction details are confirmed.")]
    Confirmed,
    
    /// <summary>
    /// Collateral giver instruction details are not recognised.
    /// 
    /// Encoded/decoded by serializers as "DKNY".
    /// </summary>
    [EnumMember(Value = "DKNY")]
    [IsoId("_euTmgcf0EemlRYW9CHJ8_Q")]
    [Description(@"Collateral giver instruction details are not recognised. ")]
    NotRecognised,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ResponseStatusCodeMetadataExtensions
{
    private static readonly ResponseStatusCodeDropdownSource _dropdownSource = new ResponseStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResponseStatusCodeDropdownRow GetMetadata(this ResponseStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

