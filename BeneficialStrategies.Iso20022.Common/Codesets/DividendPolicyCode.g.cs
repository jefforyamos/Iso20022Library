
namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the dividend policy of the financial instrument.
/// </summary>
[Serializable]
[IsoId("_axET4dp-Ed-ak6NoX_4Aeg_800833900")]
[Description(@"Specifies the dividend policy of the financial instrument.")]
public enum DividendPolicyCode
{


    /// <summary>
    /// Dividend is paid daily and can be accrued.
    /// </summary>
    [IsoId("_axET4tp-Ed-ak6NoX_4Aeg_1318003656")]
    [Description("Dividend is paid daily and can be accrued.")]
    DACR,


    /// <summary>
    /// Dividend is paid in cash.
    /// </summary>
    [IsoId("_axET49p-Ed-ak6NoX_4Aeg_2079909550")]
    [Description("Dividend is paid in cash.")]
    CASH,


    /// <summary>
    /// Dividend is paid in units.
    /// </summary>
    [IsoId("_axET5Np-Ed-ak6NoX_4Aeg_2145480783")]
    [Description("Dividend is paid in units.")]
    UNIT,


    /// <summary>
    /// Dividend is paid in both Cash and Units.
    /// </summary>
    [IsoId("_axET5dp-Ed-ak6NoX_4Aeg_-385543747")]
    [Description("Dividend is paid in both Cash and Units.")]
    BOTH,

}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DividendPolicyCodeMetadataExtensions
{
    private static readonly DividendPolicyCodeDropdownSource _dropdownSource = new DividendPolicyCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static EnumMetadataItem GetMetadata(this DividendPolicyCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



/// <summary>
/// The values that should be expected from a single row of dropdown data.
/// </summary>
public partial interface IDividendPolicyCodeDropdownRow : IEnumMetadataDropdownRow
{
}


/// <summary>
/// Used to inject dependencies that require dropdown choice values.
/// Understood to be uniquely a source of choices appropriate for a valid <seealso cref="DividendPolicyCode"/>.
/// </summary>
public partial interface IDividendPolicyCodeDropdownSource : IDropdownDataSource<IDividendPolicyCodeDropdownRow>
{
}


/// <summary>
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDividendPolicyCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
public partial class DividendPolicyCodeDropdownSource : EnumMetadataManager<DividendPolicyCode>, IDividendPolicyCodeDropdownSource
{
    IEnumerable<IDividendPolicyCodeDropdownRow> IDropdownDataSource<IDividendPolicyCodeDropdownRow>.DropdownValues => throw new NotImplementedException();
}

