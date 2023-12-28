﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AMFDoctrine1Code.  ISO2002 ID# _OrKFoNA-EeuSBa1PsnseFg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the approach of the Autorite des Marches Financiers (AMF) recommendation 2020-03 to which the fund complies.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OrKFoNA-EeuSBa1PsnseFg")]
[Description(@"Specifies the approach of the Autorite des Marches Financiers (AMF) recommendation 2020-03 to which the fund complies.")]
[DerivedFrom(typeof(AMFDoctrineCode))]
public enum AMFDoctrine1Code
{
    /// <summary>
    /// Approach based on a significantly engaging methodology.
    /// Encoded/decoded by serializers as "SignificantlyEngagingMethodology".
    /// </summary>
    [EnumMember(Value = "AMF1")]
    [IsoId("_SYhvQdA-EeuSBa1PsnseFg")]
    [Description(@"Approach based on a significantly engaging methodology.")]
    SignificantlyEngagingMethodology,
    
    /// <summary>
    /// Approach not meeting central communication standards or based on limited communication standards.
    /// Encoded/decoded by serializers as "NotMeetingCentralCommunicationStandards".
    /// </summary>
    [EnumMember(Value = "AMF3")]
    [IsoId("_Se75QdA-EeuSBa1PsnseFg")]
    [Description(@"Approach not meeting central communication standards or based on limited communication standards.")]
    NotMeetingCentralCommunicationStandards,
    
    /// <summary>
    /// Approach based on a non-significantly engaging methodology.
    /// Encoded/decoded by serializers as "NonSignificantlyEngagingMethodology".
    /// </summary>
    [EnumMember(Value = "AMF2")]
    [IsoId("_SlWDQdA-EeuSBa1PsnseFg")]
    [Description(@"Approach based on a non-significantly engaging methodology.")]
    NonSignificantlyEngagingMethodology,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AMFDoctrine1CodeMetadataExtensions
{
    private static readonly AMFDoctrine1CodeDropdownSource _dropdownSource = new AMFDoctrine1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAMFDoctrine1CodeDropdownRow GetMetadata(this AMFDoctrine1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


