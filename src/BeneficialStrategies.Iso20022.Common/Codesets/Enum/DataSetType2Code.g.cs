﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DataSetType2Code.  ISO2002 ID# _ayG1stp-Ed-ak6NoX_4Aeg_597609092.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of data set that is matched.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ayG1stp-Ed-ak6NoX_4Aeg_597609092")]
[Description(@"Specifies the type of data set that is matched.")]
[DerivedFrom(typeof(DataSetTypeCode))]
public enum DataSetType2Code
{
    /// <summary>
    /// Data set is a baseline.
    /// Encoded/decoded by serializers as "Baseline".
    /// </summary>
    [EnumMember(Value = "BASE")]
    [IsoId("_ayG1s9p-Ed-ak6NoX_4Aeg_597609124")]
    [Description(@"Data set is a baseline.")]
    Baseline,
    
    /// <summary>
    /// Data set is a transport data set.
    /// Encoded/decoded by serializers as "TransportDataSet".
    /// </summary>
    [EnumMember(Value = "TRDS")]
    [IsoId("_ayG1tNp-Ed-ak6NoX_4Aeg_597609125")]
    [Description(@"Data set is a transport data set.")]
    TransportDataSet,
    
    /// <summary>
    /// Data set is a commercial data set.
    /// Encoded/decoded by serializers as "CommercialDataSet".
    /// </summary>
    [EnumMember(Value = "CODS")]
    [IsoId("_ayG1tdp-Ed-ak6NoX_4Aeg_597609154")]
    [Description(@"Data set is a commercial data set.")]
    CommercialDataSet,
    
    /// <summary>
    /// Data set is an insurance data set.
    /// Encoded/decoded by serializers as "InsuranceDataSet".
    /// </summary>
    [EnumMember(Value = "INDS")]
    [IsoId("_ayG1ttp-Ed-ak6NoX_4Aeg_672416869")]
    [Description(@"Data set is an insurance data set.")]
    InsuranceDataSet,
    
    /// <summary>
    /// Data set is a certificate data set.
    /// Encoded/decoded by serializers as "CertificateDataSet".
    /// </summary>
    [EnumMember(Value = "CEDS")]
    [IsoId("_ayG1t9p-Ed-ak6NoX_4Aeg_925458258")]
    [Description(@"Data set is a certificate data set.")]
    CertificateDataSet,
    
    /// <summary>
    /// Data set is an other special certificate data set.
    /// Encoded/decoded by serializers as "OtherCertificateDataSet".
    /// </summary>
    [EnumMember(Value = "OCDS")]
    [IsoId("_ayG1uNp-Ed-ak6NoX_4Aeg_940237322")]
    [Description(@"Data set is an other special certificate data set.")]
    OtherCertificateDataSet,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DataSetType2CodeMetadataExtensions
{
    private static readonly DataSetType2CodeDropdownSource _dropdownSource = new DataSetType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDataSetType2CodeDropdownRow GetMetadata(this DataSetType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


