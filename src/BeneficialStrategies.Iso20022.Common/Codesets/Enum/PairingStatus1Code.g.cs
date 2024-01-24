﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PairingStatus1Code.  ISO2002 ID# _sPf1AF54Ee2a_-MvhEjKmA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Pairing status for an individual transaction or report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sPf1AF54Ee2a_-MvhEjKmA")]
[Description(@"Pairing status for an individual transaction or report.")]
[DerivedFrom(typeof(PairingStatusCode))]
public enum PairingStatus1Code
{
    /// <summary>
    /// Transaction has been paired.
    /// Encoded/decoded by serializers as "PARD".
    /// </summary>
    [EnumMember(Value = "PARD")]
    [IsoId("_sPf1AV54Ee2a_-MvhEjKmA")]
    [Description(@"Transaction has been paired.")]
    Paired = PairingStatusCode.Paired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has not been paired.
    /// Encoded/decoded by serializers as "UNPR".
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_sPf1Al54Ee2a_-MvhEjKmA")]
    [Description(@"Transaction has not been paired.")]
    Unpaired = PairingStatusCode.Unpaired, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PairingStatus1CodeMetadataExtensions
{
    private static readonly PairingStatus1CodeDropdownSource _dropdownSource = new PairingStatus1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPairingStatus1CodeDropdownRow GetMetadata(this PairingStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


