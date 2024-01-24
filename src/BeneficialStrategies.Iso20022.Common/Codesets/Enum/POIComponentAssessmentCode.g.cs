﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for POIComponentAssessmentCode.  ISO2002 ID# _boLEIAyKEeKa_56Jbsi1RQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of assessment of a POI component (Point of Interaction).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_boLEIAyKEeKa_56Jbsi1RQ")]
[Description(@"Type of assessment of a POI component (Point of Interaction).")]
[Derivations(typeof(POIComponentAssessment1Code))]
public enum POIComponentAssessmentCode
{
    /// <summary>
    /// Evaluation by a lab or a tool.
    /// Encoded/decoded by serializers as "EVAL".
    /// </summary>
    [EnumMember(Value = "EVAL")]
    [IsoId("_xXWtYAyKEeKa_56Jbsi1RQ")]
    [Description(@"Evaluation by a lab or a tool.")]
    Evaluation,
    
    /// <summary>
    /// Certification number delivered by a certification body.
    /// Encoded/decoded by serializers as "CERT".
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_1l-C4AyKEeKa_56Jbsi1RQ")]
    [Description(@"Certification number delivered by a certification body.")]
    Certification,
    
    /// <summary>
    /// Approval number delivered by an approval centre.
    /// Encoded/decoded by serializers as "APPL".
    /// </summary>
    [EnumMember(Value = "APPL")]
    [IsoId("_5B2T4AyKEeKa_56Jbsi1RQ")]
    [Description(@"Approval number delivered by an approval centre.")]
    Approval,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class POIComponentAssessmentCodeMetadataExtensions
{
    private static readonly POIComponentAssessmentCodeDropdownSource _dropdownSource = new POIComponentAssessmentCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPOIComponentAssessmentCodeDropdownRow GetMetadata(this POIComponentAssessmentCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


