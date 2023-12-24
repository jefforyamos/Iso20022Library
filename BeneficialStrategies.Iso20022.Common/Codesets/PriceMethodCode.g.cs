﻿

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of pricing calculation method.
/// </summary>
[Serializable]
[IsoId("_aIreM9p-Ed-ak6NoX_4Aeg_-1724055279")]
[Description(@"Specifies the type of pricing calculation method.")]
public enum PriceMethodCode
{


    /// <summary>
    /// Price will be calculated after the close of the dealing period. An investor, therefore, does not know the exact buy or sell price.
    /// </summary>
    [IsoId("_aIreNNp-Ed-ak6NoX_4Aeg_-1724055278")]
    [Description(@"Price will be calculated after the close of the dealing period. An investor, therefore, does not know the exact buy or sell price.")]
    FORW,


    /// <summary>
    /// Price is calculated at an earlier valuation point preceding the dealing period. An investor, therefore, knows the exact buy or sell price.
    /// </summary>
    [IsoId("_aIreNdp-Ed-ak6NoX_4Aeg_-1724055277")]
    [Description(@"Price is calculated at an earlier valuation point preceding the dealing period. An investor, therefore, knows the exact buy or sell price.")]
    HIST,

}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PriceMethodCodeMetadataExtensions
{
    private static readonly PriceMethodCodeDropdownSource _dropdownSource = new PriceMethodCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPriceMethodCodeDropdownRow GetMetadata(this PriceMethodCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



/// <summary>
/// The values that should be expected from a single row of dropdown data.
/// </summary>
public partial interface IPriceMethodCodeDropdownRow : IEnumMetadataDropdownRow<PriceMethodCode>
{
}


/// <summary>
/// Default implementation of <seealso cref="IPriceMethodCodeDropdownRow"/> that contains metadata embedded in the code.
/// </summary>
public partial class PriceMethodCodeDropdownRow : EnumMetadataItem<PriceMethodCode>, IPriceMethodCodeDropdownRow
{
    /// <summary>
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PriceMethodCodeDropdownRow(PriceMethodCode value, MemberInfo memberInfo) : base( value, memberInfo)
    {
    }
}


/// <summary>
/// Used to inject dependencies that require dropdown choice values.
/// Understood to be uniquely a source of choices appropriate for a valid <seealso cref="PriceMethodCode"/>.
/// </summary>
public partial interface IPriceMethodCodeDropdownSource : IDropdownDataSource<IPriceMethodCodeDropdownRow>
{
}


/// <summary>
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPriceMethodCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
public partial class PriceMethodCodeDropdownSource : EnumMetadataManager<PriceMethodCode,IPriceMethodCodeDropdownRow,PriceMethodCodeDropdownRow>
{
    public PriceMethodCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PriceMethodCodeDropdownRow(enumValue, memberInfo))
    {
    }
}

