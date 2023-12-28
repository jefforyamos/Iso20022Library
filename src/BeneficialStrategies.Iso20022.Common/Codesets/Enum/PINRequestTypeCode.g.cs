﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PINRequestTypeCode.  ISO2002 ID# _I-AAkN7AEeiwsev40qZGEQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of PIN Service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_I-AAkN7AEeiwsev40qZGEQ")]
[Description(@"Type of PIN Service.")]
public enum PINRequestTypeCode
{
    /// <summary>
    /// The Cardholder enters the PIN and the POI verifies it.
    /// Encoded/decoded by serializers as "PIAV".
    /// </summary>
    [EnumMember(Value = "PIAV")]
    [IsoId("_L2uhMN7AEeiwsev40qZGEQ")]
    [Description(@"The Cardholder enters the PIN and the POI verifies it.")]
    PINAcquisitionVerification,
    
    /// <summary>
    /// The Sale System send a previous keyed PIN and the POI verifies it.
    /// Encoded/decoded by serializers as "PIVO".
    /// </summary>
    [EnumMember(Value = "PIVO")]
    [IsoId("_OC4PsN7AEeiwsev40qZGEQ")]
    [Description(@"The Sale System send a previous keyed PIN and the POI verifies it.")]
    PINVerifyOnly,
    
    /// <summary>
    /// The cardholder enters the PIN, the POI enciphers the PIN Block and provides it as a result to the Sale System.
    /// Encoded/decoded by serializers as "PIAE".
    /// </summary>
    [EnumMember(Value = "PIAE")]
    [IsoId("_QmJdsN7AEeiwsev40qZGEQ")]
    [Description(@"The cardholder enters the PIN, the POI enciphers the PIN Block and provides it as a result to the Sale System.")]
    PINAcquisitionEncryption,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PINRequestTypeCodeMetadataExtensions
{
    private static readonly PINRequestTypeCodeDropdownSource _dropdownSource = new PINRequestTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPINRequestTypeCodeDropdownRow GetMetadata(this PINRequestTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

