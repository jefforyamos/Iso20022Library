﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for HoldingTransferableCode.  ISO2002 ID# _aV8eI9p-Ed-ak6NoX_4Aeg_1872710990.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicate whether or not registered investors are able to transfer some or all of their holdings to third parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aV8eI9p-Ed-ak6NoX_4Aeg_1872710990")]
[Description(@"Indicate whether or not registered investors are able to transfer some or all of their holdings to third parties.")]
[Derivations(typeof(HoldingTransferable1Code),typeof(ReferToFundOrderDesk1Code))]
// External derivations that should be provided by the proper interface are: 
public enum HoldingTransferableCode
{
    /// <summary>
    /// Transfer is allowed.
    /// Encoded/decoded by serializers as "TRAL".
    /// </summary>
    [EnumMember(Value = "TRAL")]
    [IsoId("_aV8eJNp-Ed-ak6NoX_4Aeg_1901341697")]
    [Description(@"Transfer is allowed.")]
    TransferAllowed,
    
    /// <summary>
    /// Transfer is not allowed.
    /// Encoded/decoded by serializers as "TRNA".
    /// </summary>
    [EnumMember(Value = "TRNA")]
    [IsoId("_aV8eJdp-Ed-ak6NoX_4Aeg_1926274407")]
    [Description(@"Transfer is not allowed.")]
    TransferNotAllowed,
    
    /// <summary>
    /// Indicates that the operation is only possible in restricted circumstances.
    /// Encoded/decoded by serializers as "RFOD".
    /// </summary>
    [EnumMember(Value = "RFOD")]
    [IsoId("_aV8eJtp-Ed-ak6NoX_4Aeg_-1992820992")]
    [Description(@"Indicates that the operation is only possible in restricted circumstances.")]
    ReferToFundOrderDesk,
    
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


