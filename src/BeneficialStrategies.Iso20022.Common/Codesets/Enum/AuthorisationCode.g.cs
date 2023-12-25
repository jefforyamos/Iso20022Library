﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AuthorisationCode.  ISO2002 ID# _bjlV8Np-Ed-ak6NoX_4Aeg_-1874566431.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the level of approval depending on a number of factors, including payment type, threshold amount or local country or operations practice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bjlV8Np-Ed-ak6NoX_4Aeg_-1874566431")]
[Description(@"Specifies the level of approval depending on a number of factors, including payment type, threshold amount or local country or operations practice.")]
public enum AuthorisationCode
{
    /// <summary>
    /// Indicates a file has been pre authorised or approved within the originating customer environment and no further approval is required.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_bjlV8dp-Ed-ak6NoX_4Aeg_-1817309753")]
    [Description(@"Indicates a file has been pre authorised or approved within the originating customer environment and no further approval is required.")]
    AUTH,
    
    /// <summary>
    /// Indicates that a file requires additional file level approval, with the ability to view both the payment information block and supporting customer credit transaction detail.
    /// </summary>
    [EnumMember(Value = "FDET")]
    [IsoId("_bjlV8tp-Ed-ak6NoX_4Aeg_-1056326828")]
    [Description(@"Indicates that a file requires additional file level approval, with the ability to view both the payment information block and supporting customer credit transaction detail.")]
    FDET,
    
    /// <summary>
    /// Indicates that a file requires additional file level approval, with the ability to view only the payment information block level information.
    /// </summary>
    [EnumMember(Value = "FSUM")]
    [IsoId("_bjlV89p-Ed-ak6NoX_4Aeg_-899328936")]
    [Description(@"Indicates that a file requires additional file level approval, with the ability to view only the payment information block level information.")]
    FSUM,
    
    /// <summary>
    /// Indicates that a file requires all customer transactions to be authorised or approved.
    /// </summary>
    [EnumMember(Value = "ILEV")]
    [IsoId("_bjlV9Np-Ed-ak6NoX_4Aeg_-584409191")]
    [Description(@"Indicates that a file requires all customer transactions to be authorised or approved.")]
    ILEV,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AuthorisationCodeMetadataExtensions
{
    private static readonly AuthorisationCodeDropdownSource _dropdownSource = new AuthorisationCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAuthorisationCodeDropdownRow GetMetadata(this AuthorisationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


