﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ChequePartyRoleCode.  ISO2002 ID# _eJokECmxEeutWNGMV2XKIQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the roles of the parties linked to a cheque.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eJokECmxEeutWNGMV2XKIQ")]
[Description(@"Specifies the roles of the parties linked to a cheque.")]
public enum ChequePartyRoleCode
{
    /// <summary>
    /// Party that receives an amount of money as specified in the cheque.
    /// </summary>
    [EnumMember(Value = "PAYE")]
    [IsoId("_hn9FECmxEeutWNGMV2XKIQ")]
    [Description(@"Party that receives an amount of money as specified in the cheque.")]
    PAYE,
    
    /// <summary>
    /// Specifies the agent servicing the account of the cheque payer.
    /// </summary>
    [EnumMember(Value = "DWRA")]
    [IsoId("_htiIoCmxEeutWNGMV2XKIQ")]
    [Description(@"Specifies the agent servicing the account of the cheque payer.")]
    DWRA,
    
    /// <summary>
    /// Specifies the agent on which a cheque is drawn, that is the financial institution that services the account of the payee that issued the cheque.
    /// </summary>
    [EnumMember(Value = "DWEA")]
    [IsoId("_hxVqkCmxEeutWNGMV2XKIQ")]
    [Description(@"Specifies the agent on which a cheque is drawn, that is the financial institution that services the account of the payee that issued the cheque.")]
    DWEA,
    
    /// <summary>
    /// Party that issues a cheque ordering the drawee agent to pay a specific amount, upon demand, to the payee.
    /// </summary>
    [EnumMember(Value = "PAYR")]
    [IsoId("_j2rmcCmxEeutWNGMV2XKIQ")]
    [Description(@"Party that issues a cheque ordering the drawee agent to pay a specific amount, upon demand, to the payee.")]
    PAYR,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ChequePartyRoleCodeMetadataExtensions
{
    private static readonly ChequePartyRoleCodeDropdownSource _dropdownSource = new ChequePartyRoleCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IChequePartyRoleCodeDropdownRow GetMetadata(this ChequePartyRoleCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


