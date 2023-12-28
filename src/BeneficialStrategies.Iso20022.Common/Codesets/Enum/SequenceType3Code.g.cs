﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SequenceType3Code.  ISO2002 ID# _t90OI1kyEeGeoaLUQk__nA_2097556198.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the current transaction that belongs to a sequence of transactions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t90OI1kyEeGeoaLUQk__nA_2097556198")]
[Description(@"Specifies the type of the current transaction that belongs to a sequence of transactions.")]
[DerivedFrom(typeof(SequenceTypeCode))]
public enum SequenceType3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "First".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_t90OJFkyEeGeoaLUQk__nA_908612180")]
    [Description(@"??")]
    First,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Recurring".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_t99_IFkyEeGeoaLUQk__nA_1026483165")]
    [Description(@"??")]
    Recurring,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Final".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_t99_IVkyEeGeoaLUQk__nA_-1801335368")]
    [Description(@"??")]
    Final,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OneOff".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_t99_IlkyEeGeoaLUQk__nA_1948646475")]
    [Description(@"??")]
    OneOff,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Represented".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_t99_I1kyEeGeoaLUQk__nA_-1832965217")]
    [Description(@"??")]
    Represented,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SequenceType3CodeMetadataExtensions
{
    private static readonly SequenceType3CodeDropdownSource _dropdownSource = new SequenceType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISequenceType3CodeDropdownRow GetMetadata(this SequenceType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

