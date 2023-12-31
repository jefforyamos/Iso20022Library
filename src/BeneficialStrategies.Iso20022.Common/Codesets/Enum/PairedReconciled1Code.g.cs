﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PairedReconciled1Code.  ISO2002 ID# _KoEfcGJuEeiVRNxFJ2pSfQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Common report status for all individual reports sent / received.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KoEfcGJuEeiVRNxFJ2pSfQ")]
[Description(@"Common report status for all individual reports sent / received.")]
[DerivedFrom(typeof(PairedReconciledCode))]
public enum PairedReconciled1Code
{
    /// <summary>
    /// Paired.
    /// Encoded/decoded by serializers as "Paired".
    /// </summary>
    [EnumMember(Value = "PARD")]
    [IsoId("_NFpVIGJuEeiVRNxFJ2pSfQ")]
    [Description(@"Paired.")]
    Paired,
    
    /// <summary>
    /// Reconciled.
    /// Encoded/decoded by serializers as "Reconciled".
    /// </summary>
    [EnumMember(Value = "RECO")]
    [IsoId("_NWlUIWJuEeiVRNxFJ2pSfQ")]
    [Description(@"Reconciled.")]
    Reconciled,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PairedReconciled1CodeMetadataExtensions
{
    private static readonly PairedReconciled1CodeDropdownSource _dropdownSource = new PairedReconciled1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPairedReconciled1CodeDropdownRow GetMetadata(this PairedReconciled1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


