﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TypeOfAmount18Code.  ISO2002 ID# _441QsPPwEeihCvvpsmGI2w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification or qualification of the type of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_441QsPPwEeihCvvpsmGI2w")]
[Description(@"Identification or qualification of the type of amount.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
public enum TypeOfAmount18Code
{
    /// <summary>
    /// Transaction amount that has been authorised.
    /// Encoded/decoded by serializers as "AuthorisedAmount".
    /// </summary>
    [EnumMember(Value = "AMTH")]
    [IsoId("_8FG_cfPwEeihCvvpsmGI2w")]
    [Description(@"Transaction amount that has been authorised.")]
    AuthorisedAmount,
    
    /// <summary>
    /// Baggage related fees
    /// Encoded/decoded by serializers as "Baggage".
    /// </summary>
    [EnumMember(Value = "BAGG")]
    [IsoId("_8RmjUfPwEeihCvvpsmGI2w")]
    [Description(@"Baggage related fees")]
    Baggage,
    
    /// <summary>
    /// Amount that has been charged to card account
    /// Encoded/decoded by serializers as "ChargedToCard".
    /// </summary>
    [EnumMember(Value = "CHTC")]
    [IsoId("_8oTzIfPwEeihCvvpsmGI2w")]
    [Description(@"Amount that has been charged to card account")]
    ChargedToCard,
    
    /// <summary>
    /// Data communication related charges
    /// Encoded/decoded by serializers as "Data".
    /// </summary>
    [EnumMember(Value = "DATA")]
    [IsoId("_9OOjofPwEeihCvvpsmGI2w")]
    [Description(@"Data communication related charges")]
    Data,
    
    /// <summary>
    /// Fee for exchanging a ticket (modifying an itinerary)
    /// Encoded/decoded by serializers as "ExchangeTicket".
    /// </summary>
    [EnumMember(Value = "EXTK")]
    [IsoId("__EVwsfPwEeihCvvpsmGI2w")]
    [Description(@"Fee for exchanging a ticket (modifying an itinerary)")]
    ExchangeTicket,
    
    /// <summary>
    /// Extra charges (for example,  minibar, etc.)
    /// Encoded/decoded by serializers as "Extra".
    /// </summary>
    [EnumMember(Value = "EXTR")]
    [IsoId("__Oi1kfPwEeihCvvpsmGI2w")]
    [Description(@"Extra charges (for example,  minibar, etc.)")]
    Extra,
    
    /// <summary>
    /// Amount of fare
    /// Encoded/decoded by serializers as "Fare".
    /// </summary>
    [EnumMember(Value = "FARE")]
    [IsoId("__Wt6IfPwEeihCvvpsmGI2w")]
    [Description(@"Amount of fare")]
    Fare,
    
    /// <summary>
    /// Insurance charges 
    /// Encoded/decoded by serializers as "Insurance".
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_AQ64kfPxEeihCvvpsmGI2w")]
    [Description(@"Insurance charges ")]
    Insurance,
    
    /// <summary>
    /// Amount of food and beverages
    /// Encoded/decoded by serializers as "FoodBeverage".
    /// </summary>
    [EnumMember(Value = "FDBV")]
    [IsoId("_BhvnQfPxEeihCvvpsmGI2w")]
    [Description(@"Amount of food and beverages")]
    FoodBeverage,
    
    /// <summary>
    /// Miscellaneous charges not elsewhere defined
    /// Encoded/decoded by serializers as "Miscellaneous".
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_CUJUkfPxEeihCvvpsmGI2w")]
    [Description(@"Miscellaneous charges not elsewhere defined")]
    Miscellaneous,
    
    /// <summary>
    /// Other type of amount defined at national level.
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_CbM-0fPxEeihCvvpsmGI2w")]
    [Description(@"Other type of amount defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other type of amount defined at private level.
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_CgfugfPxEeihCvvpsmGI2w")]
    [Description(@"Other type of amount defined at private level.")]
    OtherPrivate,
    
    /// <summary>
    /// Phone charges
    /// Encoded/decoded by serializers as "Phone".
    /// </summary>
    [EnumMember(Value = "PHNE")]
    [IsoId("_C5LUQfPxEeihCvvpsmGI2w")]
    [Description(@"Phone charges")]
    Phone,
    
    /// <summary>
    /// Amount of prepayment
    /// Encoded/decoded by serializers as "Prepayment".
    /// </summary>
    [EnumMember(Value = "PRPY")]
    [IsoId("_DBx2ofPxEeihCvvpsmGI2w")]
    [Description(@"Amount of prepayment")]
    Prepayment,
    
    /// <summary>
    /// Total amount of charges
    /// Encoded/decoded by serializers as "Total".
    /// </summary>
    [EnumMember(Value = "TOTL")]
    [IsoId("_Eu6t4fPxEeihCvvpsmGI2w")]
    [Description(@"Total amount of charges")]
    Total,
    
    /// <summary>
    /// Fee for exchanging a ticket (modifying an itinerary)
    /// Encoded/decoded by serializers as "ExchangeTicketFee".
    /// </summary>
    [EnumMember(Value = "EXTF")]
    [IsoId("_ep3jof4bEei1HdXMz5f0FQ")]
    [Description(@"Fee for exchanging a ticket (modifying an itinerary)")]
    ExchangeTicketFee,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TypeOfAmount18CodeMetadataExtensions
{
    private static readonly TypeOfAmount18CodeDropdownSource _dropdownSource = new TypeOfAmount18CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITypeOfAmount18CodeDropdownRow GetMetadata(this TypeOfAmount18Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


