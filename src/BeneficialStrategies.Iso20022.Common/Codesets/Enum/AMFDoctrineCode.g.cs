﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AMFDoctrineCode.  ISO2002 ID# _ty7h0M3AEeuAE-cYsQdwHQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the approach of the Autorite des Marches Financiers (AMF) recommendation 2020-03 to which the fund complies.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ty7h0M3AEeuAE-cYsQdwHQ")]
[Description(@"Specifies the approach of the Autorite des Marches Financiers (AMF) recommendation 2020-03 to which the fund complies.")]
public enum AMFDoctrineCode
{
    /// <summary>
    /// Approach based on a significantly engaging methodology.
    /// Encoded/decoded by serializers as "AMF1".
    /// </summary>
    [EnumMember(Value = "AMF1")]
    [IsoId("_16WU4M3AEeuAE-cYsQdwHQ")]
    [Description(@"Approach based on a significantly engaging methodology.")]
    SignificantlyEngagingMethodology,
    
    /// <summary>
    /// Approach based on a non-significantly engaging methodology.
    /// Encoded/decoded by serializers as "AMF2".
    /// </summary>
    [EnumMember(Value = "AMF2")]
    [IsoId("_5VtBcM3AEeuAE-cYsQdwHQ")]
    [Description(@"Approach based on a non-significantly engaging methodology.")]
    NonSignificantlyEngagingMethodology,
    
    /// <summary>
    /// Approach not meeting central communication standards or based on limited communication standards.
    /// Encoded/decoded by serializers as "AMF3".
    /// </summary>
    [EnumMember(Value = "AMF3")]
    [IsoId("_-MfxQM3AEeuAE-cYsQdwHQ")]
    [Description(@"Approach not meeting central communication standards or based on limited communication standards.")]
    NotMeetingCentralCommunicationStandards,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AMFDoctrineCodeMetadataExtensions
{
    private static readonly AMFDoctrineCodeDropdownSource _dropdownSource = new AMFDoctrineCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAMFDoctrineCodeDropdownRow GetMetadata(this AMFDoctrineCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

