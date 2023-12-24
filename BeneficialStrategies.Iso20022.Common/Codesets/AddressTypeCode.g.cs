

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of address.
/// </summary>
[Serializable]
[IsoId("_bm2sZ9p-Ed-ak6NoX_4Aeg_-1036380604")]
[Description(@"Specifies the type of address.")]
public enum AddressTypeCode
{


    /// <summary>
    /// Address is the home address.
    /// </summary>
    [IsoId("_bnAdYNp-Ed-ak6NoX_4Aeg_-921865024")]
    [Description(@"Address is the home address.")]
    HOME,


    /// <summary>
    /// Address is the business address.
    /// </summary>
    [IsoId("_bnAdYdp-Ed-ak6NoX_4Aeg_-921864479")]
    [Description(@"Address is the business address.")]
    BIZZ,


    /// <summary>
    /// Address is the complete postal address.
    /// </summary>
    [IsoId("_bnAdYtp-Ed-ak6NoX_4Aeg_-915401727")]
    [Description(@"Address is the complete postal address.")]
    ADDR,


    /// <summary>
    /// Address is a postal office (PO) box.
    /// </summary>
    [IsoId("_bnAdY9p-Ed-ak6NoX_4Aeg_-915401692")]
    [Description(@"Address is a postal office (PO) box.")]
    PBOX,


    /// <summary>
    /// Address is the address to which mail is sent.
    /// </summary>
    [IsoId("_bnAdZNp-Ed-ak6NoX_4Aeg_-780997656")]
    [Description(@"Address is the address to which mail is sent.")]
    MLTO,


    /// <summary>
    /// Address is the address to which delivery is to take place.
    /// </summary>
    [IsoId("_bnAdZdp-Ed-ak6NoX_4Aeg_-780076553")]
    [Description(@"Address is the address to which delivery is to take place.")]
    DLVY,

}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AddressTypeCodeMetadataExtensions
{
    private static readonly AddressTypeCodeDropdownSource _dropdownSource = new AddressTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAddressTypeCodeDropdownRow GetMetadata(this AddressTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



/// <summary>
/// The values that should be expected from a single row of dropdown data.
/// </summary>
public partial interface IAddressTypeCodeDropdownRow : IEnumMetadataDropdownRow<AddressTypeCode>
{
}


/// <summary>
/// Default implementation of <seealso cref="IAddressTypeCodeDropdownRow"/> that contains metadata embedded in the code.
/// </summary>
public partial class AddressTypeCodeDropdownRow : EnumMetadataItem<AddressTypeCode>, IAddressTypeCodeDropdownRow
{
    /// <summary>
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AddressTypeCodeDropdownRow(AddressTypeCode value, MemberInfo memberInfo) : base( value, memberInfo)
    {
    }
}


/// <summary>
/// Used to inject dependencies that require dropdown choice values.
/// Understood to be uniquely a source of choices appropriate for a valid <seealso cref="AddressTypeCode"/>.
/// </summary>
public partial interface IAddressTypeCodeDropdownSource : IDropdownDataSource<IAddressTypeCodeDropdownRow>
{
}


/// <summary>
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAddressTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
public partial class AddressTypeCodeDropdownSource : EnumMetadataManager<AddressTypeCode,IAddressTypeCodeDropdownRow,AddressTypeCodeDropdownRow>
{
    public AddressTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AddressTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}

