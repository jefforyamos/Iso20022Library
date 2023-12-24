﻿

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicate whether or not registered investors are able to transfer some or all of their holdings to third parties.
/// </summary>
[Serializable]
[IsoId("_aV8eI9p-Ed-ak6NoX_4Aeg_1872710990")]
[Description(@"Indicate whether or not registered investors are able to transfer some or all of their holdings to third parties.")]
public enum HoldingTransferableCode
{


    /// <summary>
    /// Transfer is allowed.
    /// </summary>
    [IsoId("_aV8eJNp-Ed-ak6NoX_4Aeg_1901341697")]
    [Description(@"Transfer is allowed.")]
    TRAL,


    /// <summary>
    /// Transfer is not allowed.
    /// </summary>
    [IsoId("_aV8eJdp-Ed-ak6NoX_4Aeg_1926274407")]
    [Description(@"Transfer is not allowed.")]
    TRNA,


    /// <summary>
    /// Indicates that the operation is only possible in restricted circumstances.
    /// </summary>
    [IsoId("_aV8eJtp-Ed-ak6NoX_4Aeg_-1992820992")]
    [Description(@"Indicates that the operation is only possible in restricted circumstances.")]
    RFOD,

}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class HoldingTransferableCodeMetadataExtensions
{
    private static readonly HoldingTransferableCodeDropdownSource _dropdownSource = new HoldingTransferableCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IHoldingTransferableCodeDropdownRow GetMetadata(this HoldingTransferableCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



/// <summary>
/// The values that should be expected from a single row of dropdown data.
/// </summary>
public partial interface IHoldingTransferableCodeDropdownRow : IEnumMetadataDropdownRow<HoldingTransferableCode>
{
}


/// <summary>
/// Default implementation of <seealso cref="IHoldingTransferableCodeDropdownRow"/> that contains metadata embedded in the code.
/// </summary>
public partial class HoldingTransferableCodeDropdownRow : EnumMetadataItem<HoldingTransferableCode>, IHoldingTransferableCodeDropdownRow
{
    /// <summary>
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public HoldingTransferableCodeDropdownRow(HoldingTransferableCode value, MemberInfo memberInfo) : base( value, memberInfo)
    {
    }
}


/// <summary>
/// Used to inject dependencies that require dropdown choice values.
/// Understood to be uniquely a source of choices appropriate for a valid <seealso cref="HoldingTransferableCode"/>.
/// </summary>
public partial interface IHoldingTransferableCodeDropdownSource : IDropdownDataSource<IHoldingTransferableCodeDropdownRow>
{
}


/// <summary>
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IHoldingTransferableCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
public partial class HoldingTransferableCodeDropdownSource : EnumMetadataManager<HoldingTransferableCode,IHoldingTransferableCodeDropdownRow,HoldingTransferableCodeDropdownRow>
{
    public HoldingTransferableCodeDropdownSource()
        : base( (enumValue, memberInfo) => new HoldingTransferableCodeDropdownRow(enumValue, memberInfo))
    {
    }
}

