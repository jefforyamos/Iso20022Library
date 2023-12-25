﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BlockedReasonCode.  ISO2002 ID# _iybhYxHaEeKVqeHljBM1MQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason an account is blocked.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iybhYxHaEeKVqeHljBM1MQ")]
[Description(@"Specifies the reason an account is blocked.")]
public enum BlockedReasonCode
{
    /// <summary>
    /// Commitment.
    /// </summary>
    [EnumMember(Value = "CMMT")]
    [IsoId("_qE3NMBHaEeKVqeHljBM1MQ")]
    [Description(@"Commitment.")]
    CMMT,
    
    /// <summary>
    /// Pledged.
    /// </summary>
    [EnumMember(Value = "PLDG")]
    [IsoId("_qTKu8BHaEeKVqeHljBM1MQ")]
    [Description(@"Pledged.")]
    PLDG,
    
    /// <summary>
    /// Confiscation.
    /// </summary>
    [EnumMember(Value = "CNFS")]
    [IsoId("_rQHfYBHaEeKVqeHljBM1MQ")]
    [Description(@"Confiscation.")]
    CNFS,
    
    /// <summary>
    /// Bankruptcy.
    /// </summary>
    [EnumMember(Value = "BKRP")]
    [IsoId("_rZgE4BHaEeKVqeHljBM1MQ")]
    [Description(@"Bankruptcy.")]
    BKRP,
    
    /// <summary>
    /// Reserved in contemplation of death.
    /// </summary>
    [EnumMember(Value = "MORT")]
    [IsoId("_rjV9YBHaEeKVqeHljBM1MQ")]
    [Description(@"Reserved in contemplation of death.")]
    MORT,
    
    /// <summary>
    /// Transfer.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_rs4T4BHaEeKVqeHljBM1MQ")]
    [Description(@"Transfer.")]
    TRAN,
    
    /// <summary>
    /// Reregistration.
    /// </summary>
    [EnumMember(Value = "TRPE")]
    [IsoId("_r1rDgBHaEeKVqeHljBM1MQ")]
    [Description(@"Reregistration.")]
    TRPE,
    
    /// <summary>
    /// Sanctions are in place.
    /// </summary>
    [EnumMember(Value = "SANC")]
    [IsoId("_ZiGRsFsMEeaY86V9afpFqA")]
    [Description(@"Sanctions are in place.")]
    SANC,
    
    /// <summary>
    /// Pending compliance verification.
    /// </summary>
    [EnumMember(Value = "PCOM")]
    [IsoId("_ZnwNwFsMEeaY86V9afpFqA")]
    [Description(@"Pending compliance verification.")]
    PCOM,
    
    /// <summary>
    /// Account closing is in process.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_3ES48GBqEeaHEJD5P6-ccw")]
    [Description(@"Account closing is in process.")]
    CLOS,
    
    /// <summary>
    /// Account was pending opening but is now rejected.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_nBWeIGCIEeabZtzjEVWYCQ")]
    [Description(@"Account was pending opening but is now rejected.")]
    REJT,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BlockedReasonCodeMetadataExtensions
{
    private static readonly BlockedReasonCodeDropdownSource _dropdownSource = new BlockedReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBlockedReasonCodeDropdownRow GetMetadata(this BlockedReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


