﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PairingStatusCode.  ISO2002 ID# _sPf1A154Ee2a_-MvhEjKmA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Pairing status for an individual transaction or report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sPf1A154Ee2a_-MvhEjKmA")]
[Description(@"Pairing status for an individual transaction or report.")]
[Derivations(typeof(PairingStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum PairingStatusCode
{
    /// <summary>
    /// Transaction has been paired.
    /// Encoded/decoded by serializers as "PARD".
    /// </summary>
    [EnumMember(Value = "PARD")]
    [IsoId("_sPf1Bl54Ee2a_-MvhEjKmA")]
    [Description(@"Transaction has been paired.")]
    Paired,
    
    /// <summary>
    /// Transaction has not been paired.
    /// Encoded/decoded by serializers as "UNPR".
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_sPf1BV54Ee2a_-MvhEjKmA")]
    [Description(@"Transaction has not been paired.")]
    Unpaired,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PairingStatusCodeMetadataExtensions
{
    private static readonly PairingStatusCodeDropdownSource _dropdownSource = new PairingStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPairingStatusCodeDropdownRow GetMetadata(this PairingStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


