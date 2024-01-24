﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MOTO1Code.  ISO2002 ID# _3MsO4DHLEeyTT91yHXSlSQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// A code that identifies the type of MOTO transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3MsO4DHLEeyTT91yHXSlSQ")]
[Description(@"A code that identifies the type of MOTO transaction.")]
[DerivedFrom(typeof(MOTOCode))]
public enum MOTO1Code
{
    /// <summary>
    /// Mail order.
    /// Encoded/decoded by serializers as "MAOR".
    /// </summary>
    [EnumMember(Value = "MAOR")]
    [IsoId("_V2gisTxSEeyuG4d2lhAp-w")]
    [Description(@"Mail order.")]
    MailOrder = MOTOCode.MailOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mail order or telephone order.
    /// Encoded/decoded by serializers as "MOTO".
    /// </summary>
    [EnumMember(Value = "MOTO")]
    [IsoId("_V6r4ETxSEeyuG4d2lhAp-w")]
    [Description(@"Mail order or telephone order.|")]
    MailOrderOrTelephoneOrder = MOTOCode.MailOrderOrTelephoneOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Telephone order
    /// Encoded/decoded by serializers as "TPOR".
    /// </summary>
    [EnumMember(Value = "TPOR")]
    [IsoId("_V-eL4TxSEeyuG4d2lhAp-w")]
    [Description(@"Telephone order")]
    TelephoneOrder = MOTOCode.TelephoneOrder, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MOTO1CodeMetadataExtensions
{
    private static readonly MOTO1CodeDropdownSource _dropdownSource = new MOTO1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMOTO1CodeDropdownRow GetMetadata(this MOTO1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


