﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProrationType1Code.  ISO2002 ID# _cnUUEDFsEeGKkIZzgd38VA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Jasdec codes for the specific use of pro ration.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cnUUEDFsEeGKkIZzgd38VA")]
[Description(@"Jasdec codes for the specific use of pro ration.")]
[DerivedFrom(typeof(ProrationTypeCode))]
public enum ProrationType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PRND".
    /// </summary>
    [EnumMember(Value = "PRND")]
    [IsoId("_d7XV5jFsEeGKkIZzgd38VA")]
    [Description(@"??")]
    NotDecided,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PRNU".
    /// </summary>
    [EnumMember(Value = "PRNU")]
    [IsoId("_DIpHtjVFEeGIoujPqYSZDw")]
    [Description(@"??")]
    NotUsed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ProrationType1CodeMetadataExtensions
{
    private static readonly ProrationType1CodeDropdownSource _dropdownSource = new ProrationType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IProrationType1CodeDropdownRow GetMetadata(this ProrationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


