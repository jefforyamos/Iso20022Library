﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ChargeBearer1Code.  ISO2002 ID# _a78HJtp-Ed-ak6NoX_4Aeg_230427680.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies which party(ies) will pay charges due for processing of the payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a78HJtp-Ed-ak6NoX_4Aeg_230427680")]
[Description(@"Specifies which party(ies) will pay charges due for processing of the payment transaction.")]
[DerivedFrom(typeof(ChargeBearerCode))]
public enum ChargeBearer1Code
{
    /// <summary>
    /// All transaction charges are to be borne by the debtor.
    /// Encoded/decoded by serializers as "BorneByDebtor".
    /// </summary>
    [EnumMember(Value = "OUR")]
    [IsoId("_a78HJ9p-Ed-ak6NoX_4Aeg_-676764336")]
    [Description(@"All transaction charges are to be borne by the debtor.")]
    BorneByDebtor,
    
    /// <summary>
    /// All transaction charges are to be borne by the creditor.
    /// Encoded/decoded by serializers as "BorneByCreditor".
    /// </summary>
    [EnumMember(Value = "BEN")]
    [IsoId("_a8F4INp-Ed-ak6NoX_4Aeg_-674914229")]
    [Description(@"All transaction charges are to be borne by the creditor.")]
    BorneByCreditor,
    
    /// <summary>
    /// Under the credit transfer scenario, transaction charges on the sender's side are to be borne by the debtor; transaction charges on the receiver's side are to be borne by the creditor.
    /// Encoded/decoded by serializers as "Shared".
    /// </summary>
    [EnumMember(Value = "SHA")]
    [IsoId("_a8F4Idp-Ed-ak6NoX_4Aeg_-671223087")]
    [Description(@"Under the credit transfer scenario, transaction charges on the sender's side are to be borne by the debtor; transaction charges on the receiver's side are to be borne by the creditor.")]
    Shared,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ChargeBearer1CodeMetadataExtensions
{
    private static readonly ChargeBearer1CodeDropdownSource _dropdownSource = new ChargeBearer1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IChargeBearer1CodeDropdownRow GetMetadata(this ChargeBearer1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


