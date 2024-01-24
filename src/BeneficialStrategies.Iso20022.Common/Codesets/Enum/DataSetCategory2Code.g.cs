﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DataSetCategory2Code.  ISO2002 ID# _KU95dH1DEeCF8NjrBemJWQ_707185954.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Category of data set to transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KU95dH1DEeCF8NjrBemJWQ_707185954")]
[Description(@"Category of data set to transfer.")]
[DerivedFrom(typeof(DataSetCategoryCode))]
public enum DataSetCategory2Code
{
    /// <summary>
    /// Software module.
    /// Encoded/decoded by serializers as "SWPK".
    /// </summary>
    [EnumMember(Value = "SWPK")]
    [IsoId("_KU95dX1DEeCF8NjrBemJWQ_-1942513907")]
    [Description(@"Software module.")]
    SoftwareModule = DataSetCategoryCode.SoftwareModule, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities.
    /// Encoded/decoded by serializers as "VDPR".
    /// </summary>
    [EnumMember(Value = "VDPR")]
    [IsoId("_KU95dn1DEeCF8NjrBemJWQ_-289886399")]
    [Description(@"Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities.")]
    VendorParameters = DataSetCategoryCode.VendorParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Acquirer specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as "AQPR".
    /// </summary>
    [EnumMember(Value = "AQPR")]
    [IsoId("_KU95d31DEeCF8NjrBemJWQ_-111767727")]
    [Description(@"Acquirer specific configuration parameters for the point of interaction (POI) system.")]
    AcquirerParameters = DataSetCategoryCode.AcquirerParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment application specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as "APPR".
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_KU95eH1DEeCF8NjrBemJWQ_259585871")]
    [Description(@"Payment application specific configuration parameters for the point of interaction (POI) system.")]
    ApplicationParameters = DataSetCategoryCode.ApplicationParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as "MRPR".
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_KVHqcH1DEeCF8NjrBemJWQ_-403725465")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters = DataSetCategoryCode.MerchantParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Batch upload of transaction data (data capture of a group of transactions).
    /// Encoded/decoded by serializers as "TXCP".
    /// </summary>
    [EnumMember(Value = "TXCP")]
    [IsoId("_KVHqcX1DEeCF8NjrBemJWQ_1355381036")]
    [Description(@"Batch upload of transaction data (data capture of a group of transactions).")]
    BatchCapture = DataSetCategoryCode.BatchCapture, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Batch download response for the batch capture of transactions.
    /// Encoded/decoded by serializers as "AKCP".
    /// </summary>
    [EnumMember(Value = "AKCP")]
    [IsoId("_KVHqcn1DEeCF8NjrBemJWQ_-1286958752")]
    [Description(@"Batch download response for the batch capture of transactions.")]
    CaptureResponse = DataSetCategoryCode.CaptureResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Report of software configuration and parameter status.
    /// Encoded/decoded by serializers as "STRP".
    /// </summary>
    [EnumMember(Value = "STRP")]
    [IsoId("_KVHqc31DEeCF8NjrBemJWQ_-1108840080")]
    [Description(@"Report of software configuration and parameter status.")]
    StatusReport = DataSetCategoryCode.StatusReport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data needed to create a terminal management sub-domain.
    /// Encoded/decoded by serializers as "DLGT".
    /// </summary>
    [EnumMember(Value = "DLGT")]
    [IsoId("_KVHqdH1DEeCF8NjrBemJWQ_-1400797818")]
    [Description(@"Data needed to create a terminal management sub-domain.")]
    DelegationData = DataSetCategoryCode.DelegationData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Configuration of management plan in the point of interaction.
    /// Encoded/decoded by serializers as "MGTP".
    /// </summary>
    [EnumMember(Value = "MGTP")]
    [IsoId("_KVHqdX1DEeCF8NjrBemJWQ_358308683")]
    [Description(@"Configuration of management plan in the point of interaction.")]
    ManagementPlan = DataSetCategoryCode.ManagementPlan, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DataSetCategory2CodeMetadataExtensions
{
    private static readonly DataSetCategory2CodeDropdownSource _dropdownSource = new DataSetCategory2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDataSetCategory2CodeDropdownRow GetMetadata(this DataSetCategory2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


