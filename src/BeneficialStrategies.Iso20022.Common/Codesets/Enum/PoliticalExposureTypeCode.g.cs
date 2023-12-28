﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PoliticalExposureTypeCode.  ISO2002 ID# _7TMJ8RRuEeOKWo1NF21OVw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the political exposure type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7TMJ8RRuEeOKWo1NF21OVw")]
[Description(@"Specifies the political exposure type.")]
public enum PoliticalExposureTypeCode
{
    /// <summary>
    /// Political exposure type is domestic.
    /// Encoded/decoded by serializers as "PEXD".
    /// </summary>
    [EnumMember(Value = "PEXD")]
    [IsoId("_CDrmUBRvEeOKWo1NF21OVw")]
    [Description(@"Political exposure type is domestic.")]
    PoliticalExposureDomestic,
    
    /// <summary>
    /// Political exposure type is foreign.
    /// Encoded/decoded by serializers as "PEXF".
    /// </summary>
    [EnumMember(Value = "PEXF")]
    [IsoId("_CHiyoBRvEeOKWo1NF21OVw")]
    [Description(@"Political exposure type is foreign.")]
    PoliticalExposureForeign,
    
    /// <summary>
    /// No political exposure.
    /// Encoded/decoded by serializers as "NPEX".
    /// </summary>
    [EnumMember(Value = "NPEX")]
    [IsoId("_CjXL8BRvEeOKWo1NF21OVw")]
    [Description(@"No political exposure.")]
    NoPoliticalExposure,
    
    /// <summary>
    /// Political exposure.
    /// Encoded/decoded by serializers as "YPEX".
    /// </summary>
    [EnumMember(Value = "YPEX")]
    [IsoId("_9vrX8JUfEemC09f0MxYkRg")]
    [Description(@"Political exposure.")]
    PoliticalExposure,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PoliticalExposureTypeCodeMetadataExtensions
{
    private static readonly PoliticalExposureTypeCodeDropdownSource _dropdownSource = new PoliticalExposureTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPoliticalExposureTypeCodeDropdownRow GetMetadata(this PoliticalExposureTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


