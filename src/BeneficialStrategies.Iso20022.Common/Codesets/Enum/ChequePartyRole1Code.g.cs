﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ChequePartyRole1Code.  ISO2002 ID# _Q-jNYCmyEeutWNGMV2XKIQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the roles of the parties linked to a cheque.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Q-jNYCmyEeutWNGMV2XKIQ")]
[Description(@"Specifies the roles of the parties linked to a cheque.")]
[DerivedFrom(typeof(ChequePartyRoleCode))]
public enum ChequePartyRole1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DraweeAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aLmLwSmyEeutWNGMV2XKIQ")]
    [Description(@"??")]
    DraweeAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DrawerAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aQkLUSmyEeutWNGMV2XKIQ")]
    [Description(@"??")]
    DrawerAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Payee".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aVo4kSmyEeutWNGMV2XKIQ")]
    [Description(@"??")]
    Payee,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Payer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aeLwkSmyEeutWNGMV2XKIQ")]
    [Description(@"??")]
    Payer,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ChequePartyRole1CodeMetadataExtensions
{
    private static readonly ChequePartyRole1CodeDropdownSource _dropdownSource = new ChequePartyRole1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IChequePartyRole1CodeDropdownRow GetMetadata(this ChequePartyRole1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

