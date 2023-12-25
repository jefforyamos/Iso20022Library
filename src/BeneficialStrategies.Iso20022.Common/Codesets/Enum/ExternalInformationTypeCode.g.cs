﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalInformationTypeCode.  ISO2002 ID# _EroPkPeZEee0h5ZXun0VTA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the information type, as published in an external information type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EroPkPeZEee0h5ZXun0VTA")]
[Description(@"Specifies the information type, as published in an external information type code list. External code sets can be downloaded from www.iso20022.org.")]
public enum ExternalInformationTypeCode
{
    /// <summary>
    /// Instructions used to ease automatic request processing.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_uIbmQPRYEeuLhpyIdtJzwg")]
    [Description(@"Instructions used to ease automatic request processing.")]
    INST,
    
    /// <summary>
    /// Additional information not otherwise specified.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_uIbmQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Additional information not otherwise specified.")]
    OTHR,
    
    /// <summary>
    /// Instructions used to ease automatic request relay.
    /// </summary>
    [EnumMember(Value = "RELY")]
    [IsoId("_uIbmRvRYEeuLhpyIdtJzwg")]
    [Description(@"Instructions used to ease automatic request relay.")]
    RELY,
    
    /// <summary>
    /// Additional shipping information not otherwise specified.
    /// </summary>
    [EnumMember(Value = "SHPG")]
    [IsoId("_uIlXQPRYEeuLhpyIdtJzwg")]
    [Description(@"Additional shipping information not otherwise specified.")]
    SHPG,
    
    /// <summary>
    /// Information concerning the letters, numbers or other symbols placed on the outside of cargo to facilitate identification.
    /// </summary>
    [EnumMember(Value = "SHPM")]
    [IsoId("_uIlXQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Information concerning the letters, numbers or other symbols placed on the outside of cargo to facilitate identification.")]
    SHPM,
    
    /// <summary>
    /// Information concerning the domicile location of the seller.
    /// </summary>
    [EnumMember(Value = "SLDC")]
    [IsoId("_uIlXRvRYEeuLhpyIdtJzwg")]
    [Description(@"Information concerning the domicile location of the seller.")]
    SLDC,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalInformationTypeCodeMetadataExtensions
{
    private static readonly ExternalInformationTypeCodeDropdownSource _dropdownSource = new ExternalInformationTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalInformationTypeCodeDropdownRow GetMetadata(this ExternalInformationTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


