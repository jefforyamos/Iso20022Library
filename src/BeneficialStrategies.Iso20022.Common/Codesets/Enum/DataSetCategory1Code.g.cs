﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DataSetCategory1Code.  ISO2002 ID# _TS9qbQEcEeCQm6a_G2yO_w_-47918382.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Category of data set to transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TS9qbQEcEeCQm6a_G2yO_w_-47918382")]
[Description(@"Category of data set to transfer.")]
[DerivedFrom(typeof(DataSetCategoryCode))]
public enum DataSetCategory1Code
{
    /// <summary>
    /// Software module.
    /// Encoded/decoded by serializers as "SoftwareModule".
    /// </summary>
    [EnumMember(Value = "SWPK")]
    [IsoId("_TS9qbgEcEeCQm6a_G2yO_w_-1746547399")]
    [Description(@"Software module.")]
    SoftwareModule,
    
    /// <summary>
    /// Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities.
    /// Encoded/decoded by serializers as "VendorParameters".
    /// </summary>
    [EnumMember(Value = "VDPR")]
    [IsoId("_TS9qbwEcEeCQm6a_G2yO_w_176526559")]
    [Description(@"Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities.")]
    VendorParameters,
    
    /// <summary>
    /// Acquirer specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as "AcquirerParameters".
    /// </summary>
    [EnumMember(Value = "AQPR")]
    [IsoId("_TS9qcAEcEeCQm6a_G2yO_w_-440892528")]
    [Description(@"Acquirer specific configuration parameters for the point of interaction (POI) system.")]
    AcquirerParameters,
    
    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as "MerchantParameters".
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_TTG0UAEcEeCQm6a_G2yO_w_-1979644489")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters,
    
    /// <summary>
    /// Batch upload of transaction data (data capture of a group of transactions).
    /// Encoded/decoded by serializers as "BatchCapture".
    /// </summary>
    [EnumMember(Value = "TXCP")]
    [IsoId("_TTG0UQEcEeCQm6a_G2yO_w_287601386")]
    [Description(@"Batch upload of transaction data (data capture of a group of transactions).")]
    BatchCapture,
    
    /// <summary>
    /// Batch download response for the batch capture of transactions.
    /// Encoded/decoded by serializers as "CaptureResponse".
    /// </summary>
    [EnumMember(Value = "AKCP")]
    [IsoId("_TTG0UgEcEeCQm6a_G2yO_w_-706664908")]
    [Description(@"Batch download response for the batch capture of transactions.")]
    CaptureResponse,
    
    /// <summary>
    /// Report of software configuration and parameter status.
    /// Encoded/decoded by serializers as "StatusReport".
    /// </summary>
    [EnumMember(Value = "STRP")]
    [IsoId("_TTG0UwEcEeCQm6a_G2yO_w_1553921435")]
    [Description(@"Report of software configuration and parameter status.")]
    StatusReport,
    
    /// <summary>
    /// Data needed to create a terminal management sub-domain.
    /// Encoded/decoded by serializers as "DelegationData".
    /// </summary>
    [EnumMember(Value = "DLGT")]
    [IsoId("_TTG0VAEcEeCQm6a_G2yO_w_1217299308")]
    [Description(@"Data needed to create a terminal management sub-domain.")]
    DelegationData,
    
    /// <summary>
    /// Configuration of management plan in the point of interaction.
    /// Encoded/decoded by serializers as "ManagementPlan".
    /// </summary>
    [EnumMember(Value = "MGTP")]
    [IsoId("_TTG0VQEcEeCQm6a_G2yO_w_-2055533980")]
    [Description(@"Configuration of management plan in the point of interaction.")]
    ManagementPlan,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DataSetCategory1CodeMetadataExtensions
{
    private static readonly DataSetCategory1CodeDropdownSource _dropdownSource = new DataSetCategory1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDataSetCategory1CodeDropdownRow GetMetadata(this DataSetCategory1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


