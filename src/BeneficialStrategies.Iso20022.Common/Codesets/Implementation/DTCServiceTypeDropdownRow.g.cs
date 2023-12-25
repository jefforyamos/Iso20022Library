﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DTCServiceType.  ISO2002 ID# _14xnMDL3EeKU9IrkkToqcw_393105217.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the type of DTC (The Depository Trust Company) service, for example Cash In Lieu/ Round Up, Foreign Tax Relief, etc.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DTCServiceTypeDropdownSource"/>.
/// Implements <seealso cref="IDTCServiceTypeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_14xnMDL3EeKU9IrkkToqcw_393105217")]
public partial class DTCServiceTypeDropdownRow : EnumMetadataItem<DTCServiceType>, IDTCServiceTypeDropdownRow
{
    /// <summary>
    /// Indicates the type of DTC (The Depository Trust Company) service, for example Cash In Lieu/ Round Up, Foreign Tax Relief, etc.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DTCServiceTypeDropdownRow(DTCServiceType value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
