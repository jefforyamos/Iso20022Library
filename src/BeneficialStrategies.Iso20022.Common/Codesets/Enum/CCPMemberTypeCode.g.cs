﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CCPMemberTypeCode.  ISO2002 ID# _DohbkAGeEeutW5-TpeYJhA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of membership the collateral provider holds with the CCP.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DohbkAGeEeutW5-TpeYJhA")]
[Description(@"Specifies the type of membership the collateral provider holds with the CCP.")]
public enum CCPMemberTypeCode
{
    /// <summary>
    /// Futures Commission Merchant.
    /// 
    /// 
    /// Encoded/decoded by serializers as "FCMC".
    /// </summary>
    [EnumMember(Value = "FCMC")]
    [IsoId("_P0ZikAGeEeutW5-TpeYJhA")]
    [Description(@"Futures Commission Merchant.  ")]
    FuturesCommissionMerchant,
    
    /// <summary>
    /// General Clearing Member.
    /// 
    /// Encoded/decoded by serializers as "GCMB".
    /// </summary>
    [EnumMember(Value = "GCMB")]
    [IsoId("_clwVMAGeEeutW5-TpeYJhA")]
    [Description(@"General Clearing Member. ")]
    GeneralClearingMember,
    
    /// <summary>
    /// Direct Clearing Member.
    /// 
    /// Encoded/decoded by serializers as "DCMB".
    /// </summary>
    [EnumMember(Value = "DCMB")]
    [IsoId("_hDGqQAGeEeutW5-TpeYJhA")]
    [Description(@"Direct Clearing Member. ")]
    DirectClearingMember,
    
    /// <summary>
    /// Sponsored Clearing Member.
    ///  
    /// Encoded/decoded by serializers as "SCMB".
    /// </summary>
    [EnumMember(Value = "SCMB")]
    [IsoId("_rxAXYAGeEeutW5-TpeYJhA")]
    [Description(@"Sponsored Clearing Member.  ")]
    SponsoredClearingMember,
    
    /// <summary>
    /// Agent Clearing Member.
    /// 
    /// Encoded/decoded by serializers as "ACMB".
    /// </summary>
    [EnumMember(Value = "ACMB")]
    [IsoId("_xBv4QAGeEeutW5-TpeYJhA")]
    [Description(@"Agent Clearing Member. ")]
    AgentClearingMember,
    
    /// <summary>
    /// Clearing House.
    /// Encoded/decoded by serializers as "CCPX".
    /// </summary>
    [EnumMember(Value = "CCPX")]
    [IsoId("_57SEwAGeEeutW5-TpeYJhA")]
    [Description(@"Clearing House.")]
    ClearingHouse,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CCPMemberTypeCodeMetadataExtensions
{
    private static readonly CCPMemberTypeCodeDropdownSource _dropdownSource = new CCPMemberTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICCPMemberTypeCodeDropdownRow GetMetadata(this CCPMemberTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

