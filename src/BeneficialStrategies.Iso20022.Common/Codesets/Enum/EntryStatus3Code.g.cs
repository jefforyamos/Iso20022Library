﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EntryStatus3Code.  ISO2002 ID# _ahkfVNp-Ed-ak6NoX_4Aeg_-1206685365.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of an entry.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ahkfVNp-Ed-ak6NoX_4Aeg_-1206685365")]
[Description(@"Specifies the status of an entry.")]
[DerivedFrom(typeof(EntryStatusCode))]
public enum EntryStatus3Code
{
    /// <summary>
    /// Booked means that the transfer of money has been completed between account servicer and account owner||Usage: |Status Booked does not necessarily imply finality of money as this depends on other factors such as the payment system used, the completion of the end-to-end transaction and the terms agreed between account servicer and owner.|Status Booked is the only status that can be reversed.
    /// Encoded/decoded by serializers as "Booked".
    /// </summary>
    [EnumMember(Value = "BOOK")]
    [IsoId("_ahkfVdp-Ed-ak6NoX_4Aeg_-1206685122")]
    [Description(@"Booked means that the transfer of money has been completed between account servicer and account owner||Usage: |Status Booked does not necessarily imply finality of money as this depends on other factors such as the payment system used, the completion of the end-to-end transaction and the terms agreed between account servicer and owner.|Status Booked is the only status that can be reversed.")]
    Booked,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EntryStatus3CodeMetadataExtensions
{
    private static readonly EntryStatus3CodeDropdownSource _dropdownSource = new EntryStatus3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEntryStatus3CodeDropdownRow GetMetadata(this EntryStatus3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


