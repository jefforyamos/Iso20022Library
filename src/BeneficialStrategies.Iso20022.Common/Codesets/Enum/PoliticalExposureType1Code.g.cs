﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PoliticalExposureType1Code.  ISO2002 ID# _UW--kBRvEeOKWo1NF21OVw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the political exposure type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UW--kBRvEeOKWo1NF21OVw")]
[Description(@"Specifies the political exposure type.")]
[DerivedFrom(typeof(PoliticalExposureTypeCode))]
public enum PoliticalExposureType1Code
{
    /// <summary>
    /// No political exposure.
    /// Encoded/decoded by serializers as "NPEX".
    /// </summary>
    [EnumMember(Value = "NPEX")]
    [IsoId("_Zojl4RRvEeOKWo1NF21OVw")]
    [Description(@"No political exposure.")]
    NoPoliticalExposure = PoliticalExposureTypeCode.NoPoliticalExposure, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Political exposure type is foreign.
    /// Encoded/decoded by serializers as "PEXF".
    /// </summary>
    [EnumMember(Value = "PEXF")]
    [IsoId("_ZyXpMRRvEeOKWo1NF21OVw")]
    [Description(@"Political exposure type is foreign.")]
    PoliticalExposureForeign = PoliticalExposureTypeCode.PoliticalExposureForeign, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Political exposure type is domestic.
    /// Encoded/decoded by serializers as "PEXD".
    /// </summary>
    [EnumMember(Value = "PEXD")]
    [IsoId("_Z8CikRRvEeOKWo1NF21OVw")]
    [Description(@"Political exposure type is domestic.")]
    PoliticalExposureDomestic = PoliticalExposureTypeCode.PoliticalExposureDomestic, // same ordinal as derivation source for type conversions
    
}
