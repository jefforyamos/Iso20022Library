﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransportTypeCode.  ISO2002 ID# _sf5qh_QDEeihCvvpsmGI2w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the transportation type code list
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sf5qh_QDEeihCvvpsmGI2w")]
[Description(@"Contains the transportation type code list")]
[Derivations(typeof(TransportType1Code))]
public enum TransportTypeCode
{
    /// <summary>
    /// Rail
    /// Encoded/decoded by serializers as "RAIL".
    /// </summary>
    [EnumMember(Value = "RAIL")]
    [IsoId("_sf5qiPQDEeihCvvpsmGI2w")]
    [Description(@"Rail")]
    Rail,
    
    /// <summary>
    /// Ship
    /// Encoded/decoded by serializers as "SHIP".
    /// </summary>
    [EnumMember(Value = "SHIP")]
    [IsoId("_sf5qi_QDEeihCvvpsmGI2w")]
    [Description(@"Ship")]
    Ship,
    
    /// <summary>
    /// Air
    /// Encoded/decoded by serializers as "AIRR".
    /// </summary>
    [EnumMember(Value = "AIRR")]
    [IsoId("_sf5qjfQDEeihCvvpsmGI2w")]
    [Description(@"Air")]
    Air,
    
    /// <summary>
    /// Bus
    /// Encoded/decoded by serializers as "BUSS".
    /// </summary>
    [EnumMember(Value = "BUSS")]
    [IsoId("_sf5qivQDEeihCvvpsmGI2w")]
    [Description(@"Bus")]
    Bus,
    
    /// <summary>
    /// Other National
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_sf5qifQDEeihCvvpsmGI2w")]
    [Description(@"Other National")]
    OtherNational,
    
    /// <summary>
    /// Other Private
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_sf5qjPQDEeihCvvpsmGI2w")]
    [Description(@"Other Private")]
    OtherPrivate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransportTypeCodeMetadataExtensions
{
    private static readonly TransportTypeCodeDropdownSource _dropdownSource = new TransportTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransportTypeCodeDropdownRow GetMetadata(this TransportTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


