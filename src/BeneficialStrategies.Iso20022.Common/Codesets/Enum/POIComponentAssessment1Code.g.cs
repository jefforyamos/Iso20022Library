﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for POIComponentAssessment1Code.  ISO2002 ID# _TBs-0Lk3EeKg8PSpEMv-Sg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of assessment of a POI component (Point of Interaction).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TBs-0Lk3EeKg8PSpEMv-Sg")]
[Description(@"Type of assessment of a POI component (Point of Interaction).")]
[DerivedFrom(typeof(POIComponentAssessmentCode))]
public enum POIComponentAssessment1Code
{
    /// <summary>
    /// Approval number delivered by an approval centre.
    /// Encoded/decoded by serializers as "Approval".
    /// </summary>
    [EnumMember(Value = "APPL")]
    [IsoId("_fAoO8bk3EeKg8PSpEMv-Sg")]
    [Description(@"Approval number delivered by an approval centre.")]
    Approval,
    
    /// <summary>
    /// Certification number delivered by a certification body.
    /// Encoded/decoded by serializers as "Certification".
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_fLolE7k3EeKg8PSpEMv-Sg")]
    [Description(@"Certification number delivered by a certification body.")]
    Certification,
    
    /// <summary>
    /// Evaluation by a lab or a tool.
    /// Encoded/decoded by serializers as "Evaluation".
    /// </summary>
    [EnumMember(Value = "EVAL")]
    [IsoId("_fUtokbk3EeKg8PSpEMv-Sg")]
    [Description(@"Evaluation by a lab or a tool.")]
    Evaluation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class POIComponentAssessment1CodeMetadataExtensions
{
    private static readonly POIComponentAssessment1CodeDropdownSource _dropdownSource = new POIComponentAssessment1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPOIComponentAssessment1CodeDropdownRow GetMetadata(this POIComponentAssessment1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


