﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DataSetCategory4Code.  ISO2002 ID# _zmd7kWpKEeSR-ZWLvO-1dg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Category of data set to transfer to the point of interaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zmd7kWpKEeSR-ZWLvO-1dg")]
[Description(@"Category of data set to transfer to the point of interaction.")]
[DerivedFrom(typeof(DataSetCategoryCode))]
public enum DataSetCategory4Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcquirerParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zzIekWpKEeSR-ZWLvO-1dg")]
    [Description(@"??")]
    AcquirerParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ApplicationParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zzIek2pKEeSR-ZWLvO-1dg")]
    [Description(@"??")]
    ApplicationParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BatchCapture".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zzIelWpKEeSR-ZWLvO-1dg")]
    [Description(@"??")]
    BatchCapture,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CaptureResponse".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zzIel2pKEeSR-ZWLvO-1dg")]
    [Description(@"??")]
    CaptureResponse,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DelegationData".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zzIemWpKEeSR-ZWLvO-1dg")]
    [Description(@"??")]
    DelegationData,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ManagementPlan".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zzIem2pKEeSR-ZWLvO-1dg")]
    [Description(@"??")]
    ManagementPlan,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MerchantParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zzIenWpKEeSR-ZWLvO-1dg")]
    [Description(@"??")]
    MerchantParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecurityParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zzIen2pKEeSR-ZWLvO-1dg")]
    [Description(@"??")]
    SecurityParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SoftwareModule".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zzIeoWpKEeSR-ZWLvO-1dg")]
    [Description(@"??")]
    SoftwareModule,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StatusReport".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zzIeo2pKEeSR-ZWLvO-1dg")]
    [Description(@"??")]
    StatusReport,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TerminalParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zzIepWpKEeSR-ZWLvO-1dg")]
    [Description(@"??")]
    TerminalParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "VendorParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zzIep2pKEeSR-ZWLvO-1dg")]
    [Description(@"??")]
    VendorParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Parameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_3DA68WpKEeSR-ZWLvO-1dg")]
    [Description(@"??")]
    Parameters,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DataSetCategory4CodeMetadataExtensions
{
    private static readonly DataSetCategory4CodeDropdownSource _dropdownSource = new DataSetCategory4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDataSetCategory4CodeDropdownRow GetMetadata(this DataSetCategory4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

