﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GovernanceProcessTypeCode.  ISO2002 ID# _EFRD0ID5Eeiw-daIkkmMqQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of governance process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EFRD0ID5Eeiw-daIkkmMqQ")]
[Description(@"Specifies a type of governance process.")]
public enum GovernanceProcessTypeCode
{
    /// <summary>
    /// Product governance procedure is pursuant to MiFID II.
    /// </summary>
    [EnumMember(Value = "AMIF")]
    [IsoId("_RLTtAID5Eeiw-daIkkmMqQ")]
    [Description(@"Product governance procedure is pursuant to MiFID II.")]
    AMIF,
    
    /// <summary>
    /// Product governance procedure is comparable to MiFID II.
    /// </summary>
    [EnumMember(Value = "BMIF")]
    [IsoId("_XyRZ8ID5Eeiw-daIkkmMqQ")]
    [Description(@"Product governance procedure is comparable to MiFID II.")]
    BMIF,
    
    /// <summary>
    /// Product governance procedure is not in accordance with MiFID II.
    /// </summary>
    [EnumMember(Value = "CMIF")]
    [IsoId("_ZZhEkID5Eeiw-daIkkmMqQ")]
    [Description(@"Product governance procedure is not in accordance with MiFID II.")]
    CMIF,
    
    /// <summary>
    /// No information is requested from the issuer.
    /// </summary>
    [EnumMember(Value = "NINF")]
    [IsoId("_bK4UgID5Eeiw-daIkkmMqQ")]
    [Description(@"No information is requested from the issuer.")]
    NINF,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GovernanceProcessTypeCodeMetadataExtensions
{
    private static readonly GovernanceProcessTypeCodeDropdownSource _dropdownSource = new GovernanceProcessTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGovernanceProcessTypeCodeDropdownRow GetMetadata(this GovernanceProcessTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


