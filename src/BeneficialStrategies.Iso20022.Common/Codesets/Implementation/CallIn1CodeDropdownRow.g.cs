﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CallIn1Code.  ISO2002 ID# _bXNt6Np-Ed-ak6NoX_4Aeg_-324730819.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of pay-in call report.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CallIn1CodeDropdownSource"/>.
/// Implements <seealso cref="ICallIn1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bXNt6Np-Ed-ak6NoX_4Aeg_-324730819")]
public partial class CallIn1CodeDropdownRow : EnumMetadataItem<CallIn1Code>, ICallIn1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of pay-in call report.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CallIn1CodeDropdownRow(CallIn1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
