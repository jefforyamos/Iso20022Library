﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CorporateActionMandatoryVoluntaryCode.  ISO2002 ID# _bKsU1dp-Ed-ak6NoX_4Aeg_735779459.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the event is mandatory, mandatory with options or voluntary.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CorporateActionMandatoryVoluntaryCodeDropdownSource"/>.
/// Implements <seealso cref="ICorporateActionMandatoryVoluntaryCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bKsU1dp-Ed-ak6NoX_4Aeg_735779459")]
public partial class CorporateActionMandatoryVoluntaryCodeDropdownRow : EnumMetadataItem<CorporateActionMandatoryVoluntaryCode>, ICorporateActionMandatoryVoluntaryCodeDropdownRow
{
    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CorporateActionMandatoryVoluntaryCodeDropdownRow(CorporateActionMandatoryVoluntaryCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
