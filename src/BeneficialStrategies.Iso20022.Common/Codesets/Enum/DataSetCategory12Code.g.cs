﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DataSetCategory12Code.  ISO2002 ID# _NLHlwdqMEeearpaEPXv9UA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Category of data set.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NLHlwdqMEeearpaEPXv9UA")]
[Description(@"Category of data set.")]
[DerivedFrom(typeof(DataSetCategoryCode))]
public enum DataSetCategory12Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcquirerParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_NXsCIdqMEeearpaEPXv9UA")]
    [Description(@"??")]
    AcquirerParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ApplicationParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_NXsCI9qMEeearpaEPXv9UA")]
    [Description(@"??")]
    ApplicationParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BatchCapture".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_NXsCJdqMEeearpaEPXv9UA")]
    [Description(@"??")]
    BatchCapture,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CaptureResponse".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_NXsCJ9qMEeearpaEPXv9UA")]
    [Description(@"??")]
    CaptureResponse,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DelegationData".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_NXsCKdqMEeearpaEPXv9UA")]
    [Description(@"??")]
    DelegationData,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ManagementPlan".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_NXsCK9qMEeearpaEPXv9UA")]
    [Description(@"??")]
    ManagementPlan,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MerchantParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_NXsCLdqMEeearpaEPXv9UA")]
    [Description(@"??")]
    MerchantParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecurityParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_NXsCL9qMEeearpaEPXv9UA")]
    [Description(@"??")]
    SecurityParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SoftwareModule".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_NXsCMdqMEeearpaEPXv9UA")]
    [Description(@"??")]
    SoftwareModule,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StatusReport".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_NXsCM9qMEeearpaEPXv9UA")]
    [Description(@"??")]
    StatusReport,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TerminalParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_NXsCNdqMEeearpaEPXv9UA")]
    [Description(@"??")]
    TerminalParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "VendorParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_NXsCN9qMEeearpaEPXv9UA")]
    [Description(@"??")]
    VendorParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Parameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_NXsCOdqMEeearpaEPXv9UA")]
    [Description(@"??")]
    Parameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TMSProtocolParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_NXsCO9qMEeearpaEPXv9UA")]
    [Description(@"??")]
    TMSProtocolParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CertificateParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_NXsCPdqMEeearpaEPXv9UA")]
    [Description(@"??")]
    CertificateParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LogFile".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_Tlwt8dqMEeearpaEPXv9UA")]
    [Description(@"??")]
    LogFile,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CertificateManagementRequest".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UA4jsdqMEeearpaEPXv9UA")]
    [Description(@"??")]
    CertificateManagementRequest,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DataSetCategory12CodeMetadataExtensions
{
    private static readonly DataSetCategory12CodeDropdownSource _dropdownSource = new DataSetCategory12CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDataSetCategory12CodeDropdownRow GetMetadata(this DataSetCategory12Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


