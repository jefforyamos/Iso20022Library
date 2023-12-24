﻿

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the form of the security.
/// </summary>
[Serializable]
[IsoId("_yTuAQNu8EeGvDJc6a1miEg_1096213532")]
[Description(@"Specifies the form of the security.")]
public enum FormOfSecurityCode
{


    /// <summary>
    /// Shareholder name of the financial instrument appears in the corporation/funds books.
    /// </summary>
    [IsoId("_arP_w9p-Ed-ak6NoX_4Aeg_1876631848")]
    [Description(@"Shareholder name of the financial instrument appears in the corporation/funds books.")]
    REGD,


    /// <summary>
    /// The financial instrument does not specify any registration of ownership, and is payable to whomever possesses the certificate.
    /// </summary>
    [IsoId("_arP_wtp-Ed-ak6NoX_4Aeg_1839687617")]
    [Description(@"The financial instrument does not specify any registration of ownership, and is payable to whomever possesses the certificate.")]
    BEAR,

}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FormOfSecurityCodeMetadataExtensions
{
    private static readonly FormOfSecurityCodeDropdownSource _dropdownSource = new FormOfSecurityCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFormOfSecurityCodeDropdownRow GetMetadata(this FormOfSecurityCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



/// <summary>
/// The values that should be expected from a single row of dropdown data.
/// </summary>
public partial interface IFormOfSecurityCodeDropdownRow : IEnumMetadataDropdownRow<FormOfSecurityCode>
{
}


/// <summary>
/// Default implementation of <seealso cref="IFormOfSecurityCodeDropdownRow"/> that contains metadata embedded in the code.
/// </summary>
public partial class FormOfSecurityCodeDropdownRow : EnumMetadataItem<FormOfSecurityCode>, IFormOfSecurityCodeDropdownRow
{
    /// <summary>
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FormOfSecurityCodeDropdownRow(FormOfSecurityCode value, MemberInfo memberInfo) : base( value, memberInfo)
    {
    }
}


/// <summary>
/// Used to inject dependencies that require dropdown choice values.
/// Understood to be uniquely a source of choices appropriate for a valid <seealso cref="FormOfSecurityCode"/>.
/// </summary>
public partial interface IFormOfSecurityCodeDropdownSource : IDropdownDataSource<IFormOfSecurityCodeDropdownRow>
{
}


/// <summary>
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFormOfSecurityCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
public partial class FormOfSecurityCodeDropdownSource : EnumMetadataManager<FormOfSecurityCode,IFormOfSecurityCodeDropdownRow,FormOfSecurityCodeDropdownRow>
{
    public FormOfSecurityCodeDropdownSource()
        : base( (enumValue, memberInfo) => new FormOfSecurityCodeDropdownRow(enumValue, memberInfo))
    {
    }
}

