﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DataSetCategory9Code.  ISO2002 ID# _F1kQ8Y3dEeW32YMP0mBeyw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Category of data set to transfer to the point of interaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_F1kQ8Y3dEeW32YMP0mBeyw")]
[Description(@"Category of data set to transfer to the point of interaction.")]
[DerivedFrom(typeof(DataSetCategoryCode))]
public enum DataSetCategory9Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcquirerParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GBoXAY3dEeW32YMP0mBeyw")]
    [Description(@"??")]
    AcquirerParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ApplicationParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GBoXA43dEeW32YMP0mBeyw")]
    [Description(@"??")]
    ApplicationParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BatchCapture".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GBoXBY3dEeW32YMP0mBeyw")]
    [Description(@"??")]
    BatchCapture,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CaptureResponse".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GBoXB43dEeW32YMP0mBeyw")]
    [Description(@"??")]
    CaptureResponse,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DelegationData".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GBoXCY3dEeW32YMP0mBeyw")]
    [Description(@"??")]
    DelegationData,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ManagementPlan".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GBoXC43dEeW32YMP0mBeyw")]
    [Description(@"??")]
    ManagementPlan,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MerchantParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GBoXDY3dEeW32YMP0mBeyw")]
    [Description(@"??")]
    MerchantParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecurityParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GBoXD43dEeW32YMP0mBeyw")]
    [Description(@"??")]
    SecurityParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SoftwareModule".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GBoXEY3dEeW32YMP0mBeyw")]
    [Description(@"??")]
    SoftwareModule,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StatusReport".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GBoXE43dEeW32YMP0mBeyw")]
    [Description(@"??")]
    StatusReport,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TerminalParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GBoXFY3dEeW32YMP0mBeyw")]
    [Description(@"??")]
    TerminalParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "VendorParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GBoXF43dEeW32YMP0mBeyw")]
    [Description(@"??")]
    VendorParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Parameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GBoXGY3dEeW32YMP0mBeyw")]
    [Description(@"??")]
    Parameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TMSProtocolParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Lx4eYY3dEeW32YMP0mBeyw")]
    [Description(@"??")]
    TMSProtocolParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CertificateParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cpAMgY3dEeW32YMP0mBeyw")]
    [Description(@"??")]
    CertificateParameters,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DataSetCategory9CodeMetadataExtensions
{
    private static readonly DataSetCategory9CodeDropdownSource _dropdownSource = new DataSetCategory9CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDataSetCategory9CodeDropdownRow GetMetadata(this DataSetCategory9Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

