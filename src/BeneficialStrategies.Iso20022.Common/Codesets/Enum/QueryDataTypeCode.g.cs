﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for QueryDataTypeCode.  ISO2002 ID# _cklwEKa-EeSxuMLA5o46jQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the inquiry type of the data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cklwEKa-EeSxuMLA5o46jQ")]
[Description(@"Specifies the inquiry type of the data.")]
public enum QueryDataTypeCode
{
    /// <summary>
    /// Query for tading data of foreign exchange.
    /// </summary>
    [EnumMember(Value = "QFXT")]
    [IsoId("_n6_AkKa-EeSxuMLA5o46jQ")]
    [Description(@"Query for tading data of foreign exchange.")]
    QFXT,
    
    /// <summary>
    /// Query for tading data of option.
    /// </summary>
    [EnumMember(Value = "QOTD")]
    [IsoId("_oEHucKa-EeSxuMLA5o46jQ")]
    [Description(@"Query for tading data of option.")]
    QOTD,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class QueryDataTypeCodeMetadataExtensions
{
    private static readonly QueryDataTypeCodeDropdownSource _dropdownSource = new QueryDataTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IQueryDataTypeCodeDropdownRow GetMetadata(this QueryDataTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


