﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesExitReasonCode.  ISO2002 ID# _10TW4DL3EeKU9IrkkToqcw_111370307.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for DTC (The Depository Trust Company) to exit the shares.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_10TW4DL3EeKU9IrkkToqcw_111370307")]
[Description(@"Specifies the reason for DTC (The Depository Trust Company) to exit the shares.")]
[Derivations(typeof(SecuritiesExitReason1Code))]
// External derivations that should be provided by the proper interface are: 
public enum SecuritiesExitReasonCode
{
    /// <summary>
    /// Shares are restricted.
    /// Encoded/decoded by serializers as "REST".
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_10TW4TL3EeKU9IrkkToqcw_-297324899")]
    [Description(@"Shares are restricted.")]
    Restricted,
    
    /// <summary>
    /// Shares are non transferable.
    /// Encoded/decoded by serializers as "NTRN".
    /// </summary>
    [EnumMember(Value = "NTRN")]
    [IsoId("_10TW4jL3EeKU9IrkkToqcw_-471335363")]
    [Description(@"Shares are non transferable.")]
    NonTransferable,
    
    /// <summary>
    /// Other reason.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_10TW4zL3EeKU9IrkkToqcw_849534733")]
    [Description(@"Other reason.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesExitReasonCodeMetadataExtensions
{
    private static readonly SecuritiesExitReasonCodeDropdownSource _dropdownSource = new SecuritiesExitReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesExitReasonCodeDropdownRow GetMetadata(this SecuritiesExitReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


