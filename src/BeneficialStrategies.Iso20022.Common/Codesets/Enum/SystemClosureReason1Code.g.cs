﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SystemClosureReason1Code.  ISO2002 ID# _ZRQG8tp-Ed-ak6NoX_4Aeg_2007403394.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for system inactivity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZRQG8tp-Ed-ak6NoX_4Aeg_2007403394")]
[Description(@"Specifies the reason for system inactivity.")]
[DerivedFrom(typeof(SystemClosureReasonCode))]
public enum SystemClosureReason1Code
{
    /// <summary>
    /// System is closed due to a bank holiday.
    /// Encoded/decoded by serializers as "BHOL".
    /// </summary>
    [EnumMember(Value = "BHOL")]
    [IsoId("_ZRQG89p-Ed-ak6NoX_4Aeg_2007403395")]
    [Description(@"System is closed due to a bank holiday.")]
    BankingHoliday = SystemClosureReasonCode.BankingHoliday, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// System is closed for maintenance reasons.
    /// Encoded/decoded by serializers as "SMTN".
    /// </summary>
    [EnumMember(Value = "SMTN")]
    [IsoId("_ZRQG9Np-Ed-ak6NoX_4Aeg_2007403396")]
    [Description(@"System is closed for maintenance reasons.")]
    SystemMaintenance = SystemClosureReasonCode.SystemMaintenance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// System is not processing any operation.
    /// Encoded/decoded by serializers as "NOOP".
    /// </summary>
    [EnumMember(Value = "NOOP")]
    [IsoId("_ZRQG9dp-Ed-ak6NoX_4Aeg_2007403397")]
    [Description(@"System is not processing any operation.")]
    NoOperation = SystemClosureReasonCode.NoOperation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// System is not operational during recovery operations.
    /// Encoded/decoded by serializers as "RCVR".
    /// </summary>
    [EnumMember(Value = "RCVR")]
    [IsoId("_ZRQG9tp-Ed-ak6NoX_4Aeg_2007403398")]
    [Description(@"System is not operational during recovery operations.")]
    Recovery = SystemClosureReasonCode.Recovery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// System is not operational during allowed downtime windows.
    /// Encoded/decoded by serializers as "ADTW".
    /// </summary>
    [EnumMember(Value = "ADTW")]
    [IsoId("_ZRQG99p-Ed-ak6NoX_4Aeg_2007403406")]
    [Description(@"System is not operational during allowed downtime windows.")]
    AllowedDowntimeWindow = SystemClosureReasonCode.AllowedDowntimeWindow, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SystemClosureReason1CodeMetadataExtensions
{
    private static readonly SystemClosureReason1CodeDropdownSource _dropdownSource = new SystemClosureReason1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISystemClosureReason1CodeDropdownRow GetMetadata(this SystemClosureReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


