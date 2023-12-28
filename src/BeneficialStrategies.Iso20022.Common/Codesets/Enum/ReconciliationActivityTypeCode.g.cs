﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReconciliationActivityTypeCode.  ISO2002 ID# _ikZkgCX_Eeym0KcvJF9aDQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code to indicate the activity type to be reconciled
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ikZkgCX_Eeym0KcvJF9aDQ")]
[Description(@"Code to indicate the activity type to be reconciled")]
public enum ReconciliationActivityTypeCode
{
    /// <summary>
    /// Acquiring activity.
    /// Encoded/decoded by serializers as "ACQG".
    /// </summary>
    [EnumMember(Value = "ACQG")]
    [IsoId("_wAVlMCX_Eeym0KcvJF9aDQ")]
    [Description(@"Acquiring activity.")]
    Acquiring,
    
    /// <summary>
    /// Issuing activity
    /// Encoded/decoded by serializers as "ISSG".
    /// </summary>
    [EnumMember(Value = "ISSG")]
    [IsoId("_HGWegCYAEeym0KcvJF9aDQ")]
    [Description(@"Issuing activity")]
    Issuing,
    
    /// <summary>
    /// All types of activity.
    /// Encoded/decoded by serializers as "CNSD".
    /// </summary>
    [EnumMember(Value = "CNSD")]
    [IsoId("_TcHhUCYAEeym0KcvJF9aDQ")]
    [Description(@"All types of activity.")]
    Consolidated,
    
    /// <summary>
    /// Other reconciliation activity type defined at private level 
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_ckuroCYAEeym0KcvJF9aDQ")]
    [Description(@"Other reconciliation activity type defined at private level ")]
    OtherPrivate,
    
    /// <summary>
    /// Other reconciliation activity type defined at national level
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_uAjCQCYAEeym0KcvJF9aDQ")]
    [Description(@"Other reconciliation activity type defined at national level")]
    OtherNational,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReconciliationActivityTypeCodeMetadataExtensions
{
    private static readonly ReconciliationActivityTypeCodeDropdownSource _dropdownSource = new ReconciliationActivityTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReconciliationActivityTypeCodeDropdownRow GetMetadata(this ReconciliationActivityTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


