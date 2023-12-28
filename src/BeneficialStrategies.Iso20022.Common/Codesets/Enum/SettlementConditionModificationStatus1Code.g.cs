﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementConditionModificationStatus1Code.  ISO2002 ID# _ZK1889p-Ed-ak6NoX_4Aeg_1791512487.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a securities settlement condition modification request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZK1889p-Ed-ak6NoX_4Aeg_1791512487")]
[Description(@"Specifies the status of a securities settlement condition modification request.")]
[DerivedFrom(typeof(SettlementConditionModificationStatusStatusCode))]
public enum SettlementConditionModificationStatus1Code
{
    /// <summary>
    /// Instruction has been acknowledged/accepted by the account servicer.
    /// Encoded/decoded by serializers as "AcknowledgedAccepted".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_ZK189Np-Ed-ak6NoX_4Aeg_-858187374")]
    [Description(@"Instruction has been acknowledged/accepted by the account servicer.")]
    AcknowledgedAccepted,
    
    /// <summary>
    /// Instruction has been rejected for further processing.
    /// Encoded/decoded by serializers as "Rejected".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_ZK189dp-Ed-ak6NoX_4Aeg_794440134")]
    [Description(@"Instruction has been rejected for further processing.")]
    Rejected,
    
    /// <summary>
    /// Modification is pending. At this time, it is unknown whether the modification can be affected.
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "MODP")]
    [IsoId("_ZK189tp-Ed-ak6NoX_4Aeg_1133726791")]
    [Description(@"Modification is pending. At this time, it is unknown whether the modification can be affected.")]
    Pending,
    
    /// <summary>
    /// Modification Request will not be executed.
    /// Encoded/decoded by serializers as "Denied".
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_ZK1899p-Ed-ak6NoX_4Aeg_-155303300")]
    [Description(@"Modification Request will not be executed.")]
    Denied,
    
    /// <summary>
    /// Modification has been completed.
    /// Encoded/decoded by serializers as "Completed".
    /// </summary>
    [EnumMember(Value = "MODC")]
    [IsoId("_ZK18-Np-Ed-ak6NoX_4Aeg_-974256981")]
    [Description(@"Modification has been completed.")]
    Completed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettlementConditionModificationStatus1CodeMetadataExtensions
{
    private static readonly SettlementConditionModificationStatus1CodeDropdownSource _dropdownSource = new SettlementConditionModificationStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettlementConditionModificationStatus1CodeDropdownRow GetMetadata(this SettlementConditionModificationStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


