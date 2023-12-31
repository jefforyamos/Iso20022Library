﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ModalityOfCountingCode.  ISO2002 ID# _OLoUAK-uEemJ1NnLPsTFaw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Modality through which the votes that have been recorded and counted.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ModalityOfCountingCodeDropdownSource"/>.
/// Implements <seealso cref="IModalityOfCountingCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_OLoUAK-uEemJ1NnLPsTFaw")]
public partial class ModalityOfCountingCodeDropdownRow : EnumMetadataItem<ModalityOfCountingCode>, IModalityOfCountingCodeDropdownRow
{
    /// <summary>
    /// Modality through which the votes that have been recorded and counted.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ModalityOfCountingCodeDropdownRow(ModalityOfCountingCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
