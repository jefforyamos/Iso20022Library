﻿

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether or not the fund is subject to reporting under the EU Savings Directive. Enter "Variable" if the status of the fund is likely to change from time to time.
/// </summary>
[Serializable]
[IsoId("_ai58Edp-Ed-ak6NoX_4Aeg_-428222749")]
[Description(@"Indicates whether or not the fund is subject to reporting under the EU Savings Directive. Enter ""Variable"" if the status of the fund is likely to change from time to time.")]
public enum EUSavingsDirectiveCode
{


    /// <summary>
    /// Investment Fund is in the scope of the directive.
    /// </summary>
    [IsoId("_ai58Etp-Ed-ak6NoX_4Aeg_-1192571141")]
    [Description(@"Investment Fund is in the scope of the directive.")]
    EUSI,


    /// <summary>
    /// Investment Fund is out of the scope of the directive.
    /// </summary>
    [IsoId("_ai58E9p-Ed-ak6NoX_4Aeg_-1192571140")]
    [Description(@"Investment Fund is out of the scope of the directive.")]
    EUSO,


    /// <summary>
    /// Unknown whether capital gain is in or out of the scope fo the directive.
    /// </summary>
    [IsoId("_ai58FNp-Ed-ak6NoX_4Aeg_-1192571119")]
    [Description(@"Unknown whether capital gain is in or out of the scope fo the directive.")]
    UKWN,


    /// <summary>
    /// Investment Fund may vary for inclusion in the scope of the directive.
    /// </summary>
    [IsoId("_ai58Fdp-Ed-ak6NoX_4Aeg_339285326")]
    [Description(@"Investment Fund may vary for inclusion in the scope of the directive.")]
    VARI,

}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EUSavingsDirectiveCodeMetadataExtensions
{
    private static readonly EUSavingsDirectiveCodeDropdownSource _dropdownSource = new EUSavingsDirectiveCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEUSavingsDirectiveCodeDropdownRow GetMetadata(this EUSavingsDirectiveCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



/// <summary>
/// The values that should be expected from a single row of dropdown data.
/// </summary>
public partial interface IEUSavingsDirectiveCodeDropdownRow : IEnumMetadataDropdownRow<EUSavingsDirectiveCode>
{
}


/// <summary>
/// Default implementation of <seealso cref="IEUSavingsDirectiveCodeDropdownRow"/> that contains metadata embedded in the code.
/// </summary>
public partial class EUSavingsDirectiveCodeDropdownRow : EnumMetadataItem<EUSavingsDirectiveCode>, IEUSavingsDirectiveCodeDropdownRow
{
    /// <summary>
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public EUSavingsDirectiveCodeDropdownRow(EUSavingsDirectiveCode value, MemberInfo memberInfo) : base( value, memberInfo)
    {
    }
}


/// <summary>
/// Used to inject dependencies that require dropdown choice values.
/// Understood to be uniquely a source of choices appropriate for a valid <seealso cref="EUSavingsDirectiveCode"/>.
/// </summary>
public partial interface IEUSavingsDirectiveCodeDropdownSource : IDropdownDataSource<IEUSavingsDirectiveCodeDropdownRow>
{
}


/// <summary>
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEUSavingsDirectiveCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
public partial class EUSavingsDirectiveCodeDropdownSource : EnumMetadataManager<EUSavingsDirectiveCode,IEUSavingsDirectiveCodeDropdownRow,EUSavingsDirectiveCodeDropdownRow>
{
    public EUSavingsDirectiveCodeDropdownSource()
        : base( (enumValue, memberInfo) => new EUSavingsDirectiveCodeDropdownRow(enumValue, memberInfo))
    {
    }
}

