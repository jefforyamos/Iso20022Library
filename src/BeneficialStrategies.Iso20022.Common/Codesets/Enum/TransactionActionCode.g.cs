﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransactionActionCode.  ISO2002 ID# _VgL1MNuTEeiB5uLfkg9ZJA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Action to realise on a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VgL1MNuTEeiB5uLfkg9ZJA")]
[Description(@"Action to realise on a transaction.")]
public enum TransactionActionCode
{
    /// <summary>
    /// Start a transaction by a swipe ahead mechanism, with the services which are enabled.
    /// </summary>
    [EnumMember(Value = "STAR")]
    [IsoId("_ZrkQgNuTEeiB5uLfkg9ZJA")]
    [Description(@"Start a transaction by a swipe ahead mechanism, with the services which are enabled.")]
    STAR,
    
    /// <summary>
    /// Keep quite after a swipe ahead mechanism.
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_-0oHoOzHEeiojesOXOKoug")]
    [Description(@"Keep quite after a swipe ahead mechanism.")]
    STOP,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransactionActionCodeMetadataExtensions
{
    private static readonly TransactionActionCodeDropdownSource _dropdownSource = new TransactionActionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransactionActionCodeDropdownRow GetMetadata(this TransactionActionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


