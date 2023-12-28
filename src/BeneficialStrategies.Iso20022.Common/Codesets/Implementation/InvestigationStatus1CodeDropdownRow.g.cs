﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InvestigationStatus1Code.  ISO2002 ID# _whTckFlIEeGYqvgbBHXAZw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the status of the investigation response related to a previously sent request.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InvestigationStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IInvestigationStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_whTckFlIEeGYqvgbBHXAZw")]
public partial class InvestigationStatus1CodeDropdownRow : EnumMetadataItem<InvestigationStatus1Code>, IInvestigationStatus1CodeDropdownRow
{
    /// <summary>
    /// Provides the status of the investigation response related to a previously sent request.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InvestigationStatus1CodeDropdownRow(InvestigationStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
