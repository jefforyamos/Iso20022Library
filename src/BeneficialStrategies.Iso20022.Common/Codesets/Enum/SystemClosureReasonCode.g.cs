﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SystemClosureReasonCode.  ISO2002 ID# _ZRQG-Np-Ed-ak6NoX_4Aeg_2007403378.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for system inactivity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZRQG-Np-Ed-ak6NoX_4Aeg_2007403378")]
[Description(@"Specifies the reason for system inactivity.")]
public enum SystemClosureReasonCode
{
    /// <summary>
    /// System is closed due to a bank holiday.
    /// Encoded/decoded by serializers as "BHOL".
    /// </summary>
    [EnumMember(Value = "BHOL")]
    [IsoId("_ZRZQ4Np-Ed-ak6NoX_4Aeg_2007403379")]
    [Description(@"System is closed due to a bank holiday.")]
    BankingHoliday,
    
    /// <summary>
    /// System is closed for maintenance reasons.
    /// Encoded/decoded by serializers as "SMTN".
    /// </summary>
    [EnumMember(Value = "SMTN")]
    [IsoId("_ZRZQ4dp-Ed-ak6NoX_4Aeg_2007403380")]
    [Description(@"System is closed for maintenance reasons.")]
    SystemMaintenance,
    
    /// <summary>
    /// System is not processing any operation.
    /// Encoded/decoded by serializers as "NOOP".
    /// </summary>
    [EnumMember(Value = "NOOP")]
    [IsoId("_ZRZQ4tp-Ed-ak6NoX_4Aeg_2007403389")]
    [Description(@"System is not processing any operation.")]
    NoOperation,
    
    /// <summary>
    /// System is not operational during recovery operations.
    /// Encoded/decoded by serializers as "RCVR".
    /// </summary>
    [EnumMember(Value = "RCVR")]
    [IsoId("_ZRZQ49p-Ed-ak6NoX_4Aeg_2007403390")]
    [Description(@"System is not operational during recovery operations.")]
    Recovery,
    
    /// <summary>
    /// System is not operational during allowed downtime windows.
    /// Encoded/decoded by serializers as "ADTW".
    /// </summary>
    [EnumMember(Value = "ADTW")]
    [IsoId("_ZRZQ5Np-Ed-ak6NoX_4Aeg_2007403391")]
    [Description(@"System is not operational during allowed downtime windows.")]
    AllowedDowntimeWindow,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SystemClosureReasonCodeMetadataExtensions
{
    private static readonly SystemClosureReasonCodeDropdownSource _dropdownSource = new SystemClosureReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISystemClosureReasonCodeDropdownRow GetMetadata(this SystemClosureReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

