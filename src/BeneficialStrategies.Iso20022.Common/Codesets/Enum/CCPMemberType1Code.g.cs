﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CCPMemberType1Code.  ISO2002 ID# _mKuBsAIJEeutW5-TpeYJhA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of membership the collateral provider holds with the CCP.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mKuBsAIJEeutW5-TpeYJhA")]
[Description(@"Specifies the type of membership the collateral provider holds with the CCP.")]
[DerivedFrom(typeof(CCPMemberTypeCode))]
public enum CCPMemberType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AgentClearingMember".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_oMEOYQIJEeutW5-TpeYJhA")]
    [Description(@"??")]
    AgentClearingMember,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClearingHouse".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_oVkIogIJEeutW5-TpeYJhA")]
    [Description(@"??")]
    ClearingHouse,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DirectClearingMember".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ofNM0gIJEeutW5-TpeYJhA")]
    [Description(@"??")]
    DirectClearingMember,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FuturesCommissionMerchant".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_oo9lwgIJEeutW5-TpeYJhA")]
    [Description(@"??")]
    FuturesCommissionMerchant,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "GeneralClearingMember".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_otx0UQIJEeutW5-TpeYJhA")]
    [Description(@"??")]
    GeneralClearingMember,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SponsoredClearingMember".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_o53vkgIJEeutW5-TpeYJhA")]
    [Description(@"??")]
    SponsoredClearingMember,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CCPMemberType1CodeMetadataExtensions
{
    private static readonly CCPMemberType1CodeDropdownSource _dropdownSource = new CCPMemberType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICCPMemberType1CodeDropdownRow GetMetadata(this CCPMemberType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


