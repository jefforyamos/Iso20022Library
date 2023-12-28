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
    /// ??
    /// Encoded/decoded by serializers as "SoftwareModule".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KU95dX1DEeCF8NjrBemJWQ_-1942513907")]
    [Description(@"??")]
    SoftwareModule,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "VendorParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KU95dn1DEeCF8NjrBemJWQ_-289886399")]
    [Description(@"??")]
    VendorParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AcquirerParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KU95d31DEeCF8NjrBemJWQ_-111767727")]
    [Description(@"??")]
    AcquirerParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ApplicationParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KU95eH1DEeCF8NjrBemJWQ_259585871")]
    [Description(@"??")]
    ApplicationParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MerchantParameters".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KVHqcH1DEeCF8NjrBemJWQ_-403725465")]
    [Description(@"??")]
    MerchantParameters,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BatchCapture".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KVHqcX1DEeCF8NjrBemJWQ_1355381036")]
    [Description(@"??")]
    BatchCapture,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CaptureResponse".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KVHqcn1DEeCF8NjrBemJWQ_-1286958752")]
    [Description(@"??")]
    CaptureResponse,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StatusReport".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KVHqc31DEeCF8NjrBemJWQ_-1108840080")]
    [Description(@"??")]
    StatusReport,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DelegationData".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KVHqdH1DEeCF8NjrBemJWQ_-1400797818")]
    [Description(@"??")]
    DelegationData,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ManagementPlan".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_KVHqdX1DEeCF8NjrBemJWQ_358308683")]
    [Description(@"??")]
    ManagementPlan,
    
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


