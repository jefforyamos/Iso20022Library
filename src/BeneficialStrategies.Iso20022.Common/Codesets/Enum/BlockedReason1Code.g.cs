﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BlockedReason1Code.  ISO2002 ID# _cRRFABHbEeKVqeHljBM1MQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason an account is blocked.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cRRFABHbEeKVqeHljBM1MQ")]
[Description(@"Specifies the reason an account is blocked.")]
[DerivedFrom(typeof(BlockedReasonCode))]
public enum BlockedReason1Code
{
    /// <summary>
    /// Bankruptcy.
    /// Encoded/decoded by serializers as "Bankruptcy".
    /// </summary>
    [EnumMember(Value = "BKRP")]
    [IsoId("_WeMLwRHeEeKVqeHljBM1MQ")]
    [Description(@"Bankruptcy.")]
    Bankruptcy,
    
    /// <summary>
    /// Commitment.
    /// Encoded/decoded by serializers as "Commitment".
    /// </summary>
    [EnumMember(Value = "CMMT")]
    [IsoId("_Wm-7YRHeEeKVqeHljBM1MQ")]
    [Description(@"Commitment.")]
    Commitment,
    
    /// <summary>
    /// Confiscation.
    /// Encoded/decoded by serializers as "Confiscation".
    /// </summary>
    [EnumMember(Value = "CNFS")]
    [IsoId("_WyKQoRHeEeKVqeHljBM1MQ")]
    [Description(@"Confiscation.")]
    Confiscation,
    
    /// <summary>
    /// Reserved in contemplation of death.
    /// Encoded/decoded by serializers as "MortisCausa".
    /// </summary>
    [EnumMember(Value = "MORT")]
    [IsoId("_XAKQYRHeEeKVqeHljBM1MQ")]
    [Description(@"Reserved in contemplation of death.")]
    MortisCausa,
    
    /// <summary>
    /// Pledged.
    /// Encoded/decoded by serializers as "Pledged".
    /// </summary>
    [EnumMember(Value = "PLDG")]
    [IsoId("_XOK3MRHeEeKVqeHljBM1MQ")]
    [Description(@"Pledged.")]
    Pledged,
    
    /// <summary>
    /// Reregistration.
    /// Encoded/decoded by serializers as "Reregistration".
    /// </summary>
    [EnumMember(Value = "TRPE")]
    [IsoId("_XYTqoRHeEeKVqeHljBM1MQ")]
    [Description(@"Reregistration.")]
    Reregistration,
    
    /// <summary>
    /// Transfer.
    /// Encoded/decoded by serializers as "Transfer".
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_Xmw9YRHeEeKVqeHljBM1MQ")]
    [Description(@"Transfer.")]
    Transfer,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BlockedReason1CodeMetadataExtensions
{
    private static readonly BlockedReason1CodeDropdownSource _dropdownSource = new BlockedReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBlockedReason1CodeDropdownRow GetMetadata(this BlockedReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


