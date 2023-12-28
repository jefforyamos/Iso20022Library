﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DataSetTypeCode.  ISO2002 ID# _ayQmsNp-Ed-ak6NoX_4Aeg_952185864.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of data set that is matched.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ayQmsNp-Ed-ak6NoX_4Aeg_952185864")]
[Description(@"Specifies the type of data set that is matched.")]
[Derivations(typeof(DataSetType1Code),typeof(DataSetType2Code))]
// External derivations that should be provided by the proper interface are: 
public enum DataSetTypeCode
{
    /// <summary>
    /// Data set is a baseline.
    /// Encoded/decoded by serializers as "BASE".
    /// </summary>
    [EnumMember(Value = "BASE")]
    [IsoId("_ayQmsdp-Ed-ak6NoX_4Aeg_1355767413")]
    [Description(@"Data set is a baseline.")]
    Baseline,
    
    /// <summary>
    /// Data set is a transport data set.
    /// Encoded/decoded by serializers as "TRDS".
    /// </summary>
    [EnumMember(Value = "TRDS")]
    [IsoId("_ayQmstp-Ed-ak6NoX_4Aeg_1425954834")]
    [Description(@"Data set is a transport data set.")]
    TransportDataSet,
    
    /// <summary>
    /// Data set is a commercial data set.
    /// Encoded/decoded by serializers as "CODS".
    /// </summary>
    [EnumMember(Value = "CODS")]
    [IsoId("_ayQms9p-Ed-ak6NoX_4Aeg_1497987506")]
    [Description(@"Data set is a commercial data set.")]
    CommercialDataSet,
    
    /// <summary>
    /// Data set is an insurance data set.
    /// Encoded/decoded by serializers as "INDS".
    /// </summary>
    [EnumMember(Value = "INDS")]
    [IsoId("_ayQmtNp-Ed-ak6NoX_4Aeg_1136593278")]
    [Description(@"Data set is an insurance data set.")]
    InsuranceDataSet,
    
    /// <summary>
    /// Data set is a certificate data set.
    /// Encoded/decoded by serializers as "CEDS".
    /// </summary>
    [EnumMember(Value = "CEDS")]
    [IsoId("_ayQmtdp-Ed-ak6NoX_4Aeg_1136593309")]
    [Description(@"Data set is a certificate data set.")]
    CertificateDataSet,
    
    /// <summary>
    /// Data set is an other special certificate data set.
    /// Encoded/decoded by serializers as "OCDS".
    /// </summary>
    [EnumMember(Value = "OCDS")]
    [IsoId("_ayQmttp-Ed-ak6NoX_4Aeg_1136593339")]
    [Description(@"Data set is an other special certificate data set.")]
    OtherCertificateDataSet,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DataSetTypeCodeMetadataExtensions
{
    private static readonly DataSetTypeCodeDropdownSource _dropdownSource = new DataSetTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDataSetTypeCodeDropdownRow GetMetadata(this DataSetTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


