﻿

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of signature form.
/// </summary>
[Serializable]
[IsoId("_ZPUNRtp-Ed-ak6NoX_4Aeg_1133516215")]
[Description(@"Type of signature form.")]
public enum SignatureTypeCode
{


    /// <summary>
    /// The investor's written signature is required. Can also be known as physical or wet signature.
    /// </summary>
    [IsoId("_ZPUNR9p-Ed-ak6NoX_4Aeg_1551868331")]
    [Description(@"The investor's written signature is required. Can also be known as physical or wet signature.")]
    ORIG,


    /// <summary>
    /// A technical signature that includes algorithms and private key and public key information. Used to sign and verify the contents of a message.
    /// </summary>
    [IsoId("_ZPUNSNp-Ed-ak6NoX_4Aeg_1551868361")]
    [Description(@"A technical signature that includes algorithms and private key and public key information. Used to sign and verify the contents of a message.")]
    DIGI,


    /// <summary>
    /// A copy of a physical or original signature in an electronic format.
    /// </summary>
    [IsoId("_ZPdXMNp-Ed-ak6NoX_4Aeg_1551868392")]
    [Description(@"A copy of a physical or original signature in an electronic format.")]
    ELEC,


    /// <summary>
    /// There is no signature required in any form.
    /// </summary>
    [IsoId("_ZPdXMdp-Ed-ak6NoX_4Aeg_1551868393")]
    [Description(@"There is no signature required in any form.")]
    NONE,

}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SignatureTypeCodeMetadataExtensions
{
    private static readonly SignatureTypeCodeDropdownSource _dropdownSource = new SignatureTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISignatureTypeCodeDropdownRow GetMetadata(this SignatureTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



/// <summary>
/// The values that should be expected from a single row of dropdown data.
/// </summary>
public partial interface ISignatureTypeCodeDropdownRow : IEnumMetadataDropdownRow<SignatureTypeCode>
{
}


/// <summary>
/// Default implementation of <seealso cref="ISignatureTypeCodeDropdownRow"/> that contains metadata embedded in the code.
/// </summary>
public partial class SignatureTypeCodeDropdownRow : EnumMetadataItem<SignatureTypeCode>, ISignatureTypeCodeDropdownRow
{
    /// <summary>
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SignatureTypeCodeDropdownRow(SignatureTypeCode value, MemberInfo memberInfo) : base( value, memberInfo)
    {
    }
}


/// <summary>
/// Used to inject dependencies that require dropdown choice values.
/// Understood to be uniquely a source of choices appropriate for a valid <seealso cref="SignatureTypeCode"/>.
/// </summary>
public partial interface ISignatureTypeCodeDropdownSource : IDropdownDataSource<ISignatureTypeCodeDropdownRow>
{
}


/// <summary>
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISignatureTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
public partial class SignatureTypeCodeDropdownSource : EnumMetadataManager<SignatureTypeCode,ISignatureTypeCodeDropdownRow,SignatureTypeCodeDropdownRow>
{
    public SignatureTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SignatureTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}

